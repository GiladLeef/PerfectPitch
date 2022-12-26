using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class frmMain : Form
    {
        private BackgroundWorker2 bgThread = new BackgroundWorker2();

        public frmMain()
        {
            new frmSplashScreen().ShowDialog();

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            Text = $"PerfectPitch v{Application.ProductVersion}";

            bgThread.DoWork += bgThread_DoWork;
            bgThread.RunWorkerCompleted += bgThread_RunWorkerCompleted;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var Engine = new Dictionary<string, string>()
            {
                { "auto", "Automatically Select CPU/GPU" },
                { "librosa", "LibROSA (CPU, Slower)" },
                { "tensorflow", "Google TensorFlow (GPU, Faster)" },
            };

            cboAiEngine.DataSource = new BindingSource(Engine.ToDictionary(p => p.Key, p => p.Value), null);
            cboAiEngine.DisplayMember = "Value";
            cboAiEngine.ValueMember = "Key";
            cboAiEngine.SelectedIndex = 0;

            var Stem = new Dictionary<string, string>()
            {
                { "spleeter:2stems", "Vocal + Music (Acapella & Backing Track)" },
                { "spleeter:4stems", "Vocal + Bass + Drums + Other" },
                { "spleeter:5stems", "Vocal + Bass + Drums + Piano + Other" },
            };

            cboStem.DataSource = new BindingSource(Stem.ToDictionary(p => p.Key, p => p.Value), null);
            cboStem.DisplayMember = "Value";
            cboStem.ValueMember = "Key";
            cboStem.SelectedIndex = 0;

            var Bitrate = new Dictionary<string, string>()
            {
                { "128k", "128 kbps" },
                { "192k", "192 kbps" },
                { "256k", "256 kbps" },
                { "320k", "320 kbps" },
            };

            cboBitRate.DataSource = new BindingSource(Bitrate.ToDictionary(p => p.Key, p => p.Value), null);
            cboBitRate.DisplayMember = "Value";
            cboBitRate.ValueMember = "Key";
            cboBitRate.SelectedIndex = 0;

            var Codec = new Dictionary<string, string>()
            {
                { "wav", "WAV (Waveform Audio File Format)" },
                { "flac", "FLAC (Free Lossless Audio Codec)" },
                { "ogg", "OGG (Xiph.Org Vorbis) [Lossy]" },
                { "m4a", "MP4 (Advanced Audio Coding) [Lossy]" },
                { "mp3", "MP3 (MPEG Audio Layer III) [Lossy, DO NOT USE]" },
                { "wma", "WMA (Windows Media Audio) [Lossy, DO NOT USE]" }
            };

            cboCodec.DataSource = new BindingSource(Codec.ToDictionary(p => p.Key, p => p.Value), null);
            cboCodec.DisplayMember = "Value";
            cboCodec.ValueMember = "Key";
            cboCodec.SelectedIndex = 1;
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.SavePath))
            {
                Properties.Settings.Default.SavePath = Path.GetFullPath(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "PerfectPitch"));
            }

            if (!Directory.Exists(Properties.Settings.Default.SavePath))
            {
                Directory.CreateDirectory(Properties.Settings.Default.SavePath);
            }

            chkSavePath.Checked = Properties.Settings.Default.SavePathEnable;
            txtSavePath.Text = Properties.Settings.Default.SavePath;

            cboBitRate.Enabled = (cboCodec.SelectedIndex > 1);

            timerGetVersion.Start();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.SavePathEnable = chkSavePath.Checked;
            Properties.Settings.Default.SavePath = txtSavePath.Text;
        }
        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            var w = pbxBanner.Width;
            var h = pbxBanner.Height;

            var b1 = PerfectPitch.Properties.Resources.Banner;
            var b2 = PerfectPitch.Properties.Resources.Banner;
            var iW = b1.Width;
            var iH = b1.Height;

            var p = h / (double)iH;

            var nW = iW * p;
            var nH = iH * p;

            var bL = Image2.Resize(b1, (int)nW, (int)nH);
            var bR = Image2.Resize(b2, (int)nW, (int)nH);
            try
            {
                if (w <= 0 || h <= 0)
                    return;

                using (var png = new Bitmap(w, h, PixelFormat.Format32bppArgb))
                {
                    using (var img = Graphics.FromImage(png))
                    {
                        img.DrawImage(new Bitmap(bL), 0, 0);
                        img.DrawImage(new Bitmap(bR), w - (int)nW, 0);
                    }

                    pbxBanner.BackgroundImage = new Bitmap(png);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnFileAdd_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Popular Audio File|*.mp3;*.m4a;*.flac;*.ogg;*.opus;*.wav|" + 
                            "Popular Video File|*.mkv;*.mp4;*.webm;*.ivf;*.avi;*.mpg;*.mpeg|" +
                            "All types|*.*",
                FilterIndex = 1,
                Multiselect = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in ofd.FileNames)
                {
                    lstFile_ItemsAdd(item);
                }
            }
        }

        private void btnFileRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstFile.SelectedItems)
            {
                item.Remove();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new PerfectPitch.frmAbout().ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lstFile.Items.Count > 0)
            {
                if (bgThread.IsBusy)
                {
                    return;
                }

                var data = new Dictionary<int, FileQueue>();
                foreach (ListViewItem item in lstFile.Items)
                {
                    if (!item.Checked)
                        continue;

                    data.Add(item.Index, item.Tag as FileQueue);
                    item.SubItems[4].Text = "In Queue";
                }

                if (data.Count > 0)
                {
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;

                    bgThread.RunWorkerAsync(data);
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            bgThread_Abort();
        }

        private void lstFile_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            (lstFile.Items[e.Item.Index].Tag as FileQueue).Enable = e.Item.Checked;
        }

        private void lstFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFile.SelectedItems.Count > 0)
            {
                var data = lstFile.SelectedItems[0].Tag as FileQueue;

                cboAiEngine.SelectedValue = data.Engine;
                cboStem.SelectedValue = data.Stem;
                cboBitRate.SelectedValue = data.OutputBitrate;
                cboCodec.SelectedValue = data.OutputFormat;
                nudOffset.Value = data.Offset;
                nudDuration.Value = data.Duration;
                chkMWF.Checked = data.UseMWF;
            }
        }

        private void lstFile_DragDrop(object sender, DragEventArgs e)
        {
            foreach (var item in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                lstFile_ItemsAdd(item);
            }
        }

        private void lstFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lstFile_ItemsAdd(string fileName)
        {
            lstFile.Items.Add(new ListViewItem(new[]
            {
                Path.GetFileName(fileName),
                $"{new FileInfo(fileName).LastWriteTime:yyyy/MM/dd hh:mm tt}",
                $"{Path.GetExtension(fileName).ToUpper()} File",
                $"{new FileInfo(fileName).Length} bytes",
                "Waiting..."
            })
            {
                Checked = true,
                Tag = new FileQueue()
                {
                    Enable = true,
                    FilePath = fileName,
                    Engine = cboAiEngine.SelectedValue.ToString(),
                    Stem = cboStem.SelectedValue.ToString(),
                    OutputBitrate = cboBitRate.SelectedValue.ToString(),
                    OutputFormat = cboCodec.SelectedValue.ToString(),
                    Offset = Convert.ToInt32(nudOffset.Value),
                    Duration = Convert.ToInt32(nudDuration.Value),
                    UseMWF = chkMWF.Checked
                }
            });
        }

        private void cboAiEngine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as Control).Focused)
            {
                foreach (ListViewItem queue in lstFile.SelectedItems)
                {
                    (queue.Tag as FileQueue).Engine = cboAiEngine.SelectedValue.ToString();
                }
            }
        }

        private void cboStem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as Control).Focused)
            {
                foreach (ListViewItem queue in lstFile.SelectedItems)
                {
                    (queue.Tag as FileQueue).Stem = cboStem.SelectedValue.ToString();
                }
            }
        }

        private void cboBitRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as Control).Focused)
            {
                foreach (ListViewItem queue in lstFile.SelectedItems)
                {
                    (queue.Tag as FileQueue).OutputBitrate = cboBitRate.SelectedValue.ToString();
                }
            }
        }

        private void cboCodec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBitRate.Enabled = (cboCodec.SelectedIndex > 1);

            if ((sender as Control).Focused)
            {
                foreach (ListViewItem queue in lstFile.SelectedItems)
                {
                    (queue.Tag as FileQueue).OutputFormat = cboCodec.SelectedValue.ToString();
                }
            }
        }

        private void nudOffset_Leave(object sender, EventArgs e)
        {
            foreach (ListViewItem queue in lstFile.SelectedItems)
            {
                (queue.Tag as FileQueue).Offset = Convert.ToInt32(nudOffset.Value);
            }
        }

        private void nudDuration_Leave(object sender, EventArgs e)
        {
            foreach (ListViewItem queue in lstFile.SelectedItems)
            {
                (queue.Tag as FileQueue).Duration = Convert.ToInt32(nudDuration.Value);
            }
        }

        private void chkMWF_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as Control).Focused)
            {
                foreach (ListViewItem queue in lstFile.SelectedItems)
                {
                    (queue.Tag as FileQueue).UseMWF = chkMWF.Checked;
                }
            }
        }

        private void chkSavePath_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                (sender as CheckBox).Text = "&Set a custom save location (save files on target folder)";
            }
            else
            {
                (sender as CheckBox).Text = "&Set a custom save location (save files on source folder)";
            }
        }

        private void txtSavePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSavePath_Leave(object sender, EventArgs e)
        {
            if (Path.IsPathRooted(txtSavePath.Text))
            {
                if (!Directory.Exists(txtSavePath.Text))
                {
                    var msgBox = MessageBox.Show("Do you want to create new folder?", "Save folder not exist", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (msgBox == DialogResult.Yes)
                    {
                        Directory.CreateDirectory(txtSavePath.Text);
                    }
                    else
                    {
                        txtSavePath.Text = Properties.Settings.Default.SavePath;
                    }
                }

                Properties.Settings.Default.SavePath = txtSavePath.Text;
                return;
            }

            txtSavePath.Text = Properties.Settings.Default.SavePath;
        }

        private void btnSetSavePath_Click(object sender, EventArgs e)
        {
            var fbd = new OpenFileDialog
            {
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = false,
                Title = "Select desire save location folder",
                FileName = "Choose a save folder"
            };

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                var fPath = Path.GetDirectoryName(fbd.FileName);
                Properties.Settings.Default.SavePath = fPath;
                txtSavePath.Text = fPath;
            }
        }

        private void bgThread_DoWork(object sender, DoWorkEventArgs e)
        {
            var data = e.Argument as Dictionary<int, FileQueue>;
       
            foreach (var item in data)
            {
                var id = item.Key;
                var fq = item.Value;

                if (fq.Enable)
                {
                    if (!File.Exists(fq.FilePath))
                    {
                        lstFile.Invoke((MethodInvoker)delegate
                        {
                            lstFile.Items[id].Checked = false;
                            lstFile.Items[id].SubItems[4].Text = $"File not found!";
                        });

                        continue;
                    }
                    else
                    {
                        lstFile.Invoke((MethodInvoker)delegate
                        {
                            lstFile.Items[id].Checked = false;
                            lstFile.Items[id].SubItems[4].Text = $"Processing...";
                        });
                    }

                    var savePath = chkSavePath.Checked ? txtSavePath.Text : Path.GetDirectoryName(fq.FilePath);

                    ProcessManager.Execute($"--verbose -B {fq.Engine} -p {fq.Stem} -b {fq.OutputBitrate} -c {fq.OutputFormat} -s {fq.Offset} -d {fq.Duration} {(fq.UseMWF ? "--mwf" : "")} -o \"{savePath}\" \"{fq.FilePath}\"");

                    lstFile.Invoke((MethodInvoker)delegate
                    {
                        lstFile.Items[id].SubItems[4].Text = $"Complete!";
                    });
                }
                else
                {
                    lstFile.Invoke((MethodInvoker)delegate
                    {
                        lstFile.Items[id].SubItems[4].Text = "Skip...";
                    });
                }
            }
        }

        private void bgThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        internal void bgThread_Abort()
        {
            if (bgThread.IsBusy)
            {
                bgThread.Abort();
                bgThread.Dispose();
                ProcessManager.Stop();
            }
        }

        private void timerGetVersion_Tick(object sender, EventArgs e)
        {
            Text += $" - Let's separate music tracks!";
            timerGetVersion.Stop();
        }
    }
}
