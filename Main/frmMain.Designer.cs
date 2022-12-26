
namespace Main
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbxBanner = new System.Windows.Forms.PictureBox();
            this.btnFileAdd = new System.Windows.Forms.Button();
            this.btnFileRemove = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lstFile = new System.Windows.Forms.ListView();
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileDateMod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbOptions = new System.Windows.Forms.GroupBox();
            this.chkMWF = new System.Windows.Forms.CheckBox();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.lblBitRate = new System.Windows.Forms.Label();
            this.cboBitRate = new System.Windows.Forms.ComboBox();
            this.lblCodec = new System.Windows.Forms.Label();
            this.cboCodec = new System.Windows.Forms.ComboBox();
            this.lblStem = new System.Windows.Forms.Label();
            this.cboStem = new System.Windows.Forms.ComboBox();
            this.lblAiEngine = new System.Windows.Forms.Label();
            this.cboAiEngine = new System.Windows.Forms.ComboBox();
            this.chkSavePath = new System.Windows.Forms.CheckBox();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnSetSavePath = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblSplit1 = new System.Windows.Forms.Label();
            this.timerGetVersion = new System.Windows.Forms.Timer(this.components);
            this.lblSplit2 = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).BeginInit();
            this.gpbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxBanner
            // 
            this.pbxBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxBanner.BackColor = System.Drawing.Color.Black;
            this.pbxBanner.Location = new System.Drawing.Point(0, 0);
            this.pbxBanner.Name = "pbxBanner";
            this.pbxBanner.Size = new System.Drawing.Size(800, 64);
            this.pbxBanner.TabIndex = 0;
            this.pbxBanner.TabStop = false;
            // 
            // btnFileAdd
            // 
            this.btnFileAdd.Font = new System.Drawing.Font("Wingdings 2", 11F);
            this.btnFileAdd.Location = new System.Drawing.Point(12, 76);
            this.btnFileAdd.Name = "btnFileAdd";
            this.btnFileAdd.Size = new System.Drawing.Size(32, 32);
            this.btnFileAdd.TabIndex = 0;
            this.btnFileAdd.Text = "Ë";
            this.btnFileAdd.UseVisualStyleBackColor = true;
            this.btnFileAdd.Click += new System.EventHandler(this.btnFileAdd_Click);
            // 
            // btnFileRemove
            // 
            this.btnFileRemove.Font = new System.Drawing.Font("Wingdings 2", 11F);
            this.btnFileRemove.Location = new System.Drawing.Point(50, 76);
            this.btnFileRemove.Name = "btnFileRemove";
            this.btnFileRemove.Size = new System.Drawing.Size(32, 32);
            this.btnFileRemove.TabIndex = 1;
            this.btnFileRemove.Text = "Ò";
            this.btnFileRemove.UseVisualStyleBackColor = true;
            this.btnFileRemove.Click += new System.EventHandler(this.btnFileRemove_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Wingdings 3", 11F);
            this.btnStart.Location = new System.Drawing.Point(718, 76);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(32, 32);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "u";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Wingdings 2", 11F);
            this.btnStop.Location = new System.Drawing.Point(756, 76);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(32, 32);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "¢";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lstFile
            // 
            this.lstFile.AllowDrop = true;
            this.lstFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFile.CheckBoxes = true;
            this.lstFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName,
            this.colFileDateMod,
            this.colFileType,
            this.colFileSize,
            this.colFileStatus});
            this.lstFile.FullRowSelect = true;
            this.lstFile.HideSelection = false;
            this.lstFile.Location = new System.Drawing.Point(12, 114);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(776, 217);
            this.lstFile.TabIndex = 5;
            this.lstFile.UseCompatibleStateImageBehavior = false;
            this.lstFile.View = System.Windows.Forms.View.Details;
            this.lstFile.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstFile_ItemChecked);
            this.lstFile.SelectedIndexChanged += new System.EventHandler(this.lstFile_SelectedIndexChanged);
            this.lstFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstFile_DragDrop);
            this.lstFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstFile_DragEnter);
            // 
            // colFileName
            // 
            this.colFileName.Text = "Name";
            this.colFileName.Width = 300;
            // 
            // colFileDateMod
            // 
            this.colFileDateMod.Text = "Date modified";
            this.colFileDateMod.Width = 128;
            // 
            // colFileType
            // 
            this.colFileType.Text = "Type";
            this.colFileType.Width = 100;
            // 
            // colFileSize
            // 
            this.colFileSize.Text = "Size";
            this.colFileSize.Width = 100;
            // 
            // colFileStatus
            // 
            this.colFileStatus.Text = "Status";
            this.colFileStatus.Width = 120;
            // 
            // gpbOptions
            // 
            this.gpbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbOptions.Controls.Add(this.chkMWF);
            this.gpbOptions.Controls.Add(this.nudOffset);
            this.gpbOptions.Controls.Add(this.lblDuration);
            this.gpbOptions.Controls.Add(this.nudDuration);
            this.gpbOptions.Controls.Add(this.lblBitRate);
            this.gpbOptions.Controls.Add(this.cboBitRate);
            this.gpbOptions.Controls.Add(this.lblCodec);
            this.gpbOptions.Controls.Add(this.cboCodec);
            this.gpbOptions.Controls.Add(this.lblStem);
            this.gpbOptions.Controls.Add(this.cboStem);
            this.gpbOptions.Controls.Add(this.lblAiEngine);
            this.gpbOptions.Controls.Add(this.cboAiEngine);
            this.gpbOptions.Location = new System.Drawing.Point(12, 337);
            this.gpbOptions.Name = "gpbOptions";
            this.gpbOptions.Size = new System.Drawing.Size(776, 191);
            this.gpbOptions.TabIndex = 6;
            this.gpbOptions.TabStop = false;
            this.gpbOptions.Text = "&Options";
            // 
            // chkMWF
            // 
            this.chkMWF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMWF.Location = new System.Drawing.Point(415, 141);
            this.chkMWF.Name = "chkMWF";
            this.chkMWF.Size = new System.Drawing.Size(228, 21);
            this.chkMWF.TabIndex = 11;
            this.chkMWF.Text = "Use MWF (Multi-channel Wiener Filtering)";
            this.chkMWF.UseVisualStyleBackColor = true;
            this.chkMWF.CheckedChanged += new System.EventHandler(this.chkMWF_CheckedChanged);
            // 
            // nudOffset
            // 
            this.nudOffset.Location = new System.Drawing.Point(105, 142);
            this.nudOffset.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(128, 20);
            this.nudOffset.TabIndex = 9;
            this.nudOffset.Leave += new System.EventHandler(this.nudOffset_Leave);
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuration.Location = new System.Drawing.Point(105, 116);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(280, 23);
            this.lblDuration.TabIndex = 8;
            this.lblDuration.Text = "Start Offset + Duration (in seconds):";
            this.lblDuration.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(257, 142);
            this.nudDuration.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nudDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(128, 20);
            this.nudDuration.TabIndex = 10;
            this.nudDuration.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudDuration.Leave += new System.EventHandler(this.nudDuration_Leave);
            // 
            // lblBitRate
            // 
            this.lblBitRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBitRate.Location = new System.Drawing.Point(105, 66);
            this.lblBitRate.Name = "lblBitRate";
            this.lblBitRate.Size = new System.Drawing.Size(280, 23);
            this.lblBitRate.TabIndex = 4;
            this.lblBitRate.Text = "Output Bitrate (Lossy codec only):";
            this.lblBitRate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboBitRate
            // 
            this.cboBitRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBitRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBitRate.FormattingEnabled = true;
            this.cboBitRate.Location = new System.Drawing.Point(105, 92);
            this.cboBitRate.Name = "cboBitRate";
            this.cboBitRate.Size = new System.Drawing.Size(280, 21);
            this.cboBitRate.TabIndex = 5;
            this.cboBitRate.SelectedIndexChanged += new System.EventHandler(this.cboBitRate_SelectedIndexChanged);
            // 
            // lblCodec
            // 
            this.lblCodec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodec.Location = new System.Drawing.Point(391, 66);
            this.lblCodec.Name = "lblCodec";
            this.lblCodec.Size = new System.Drawing.Size(280, 23);
            this.lblCodec.TabIndex = 6;
            this.lblCodec.Text = "Output File Format:";
            this.lblCodec.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboCodec
            // 
            this.cboCodec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodec.FormattingEnabled = true;
            this.cboCodec.Location = new System.Drawing.Point(391, 92);
            this.cboCodec.Name = "cboCodec";
            this.cboCodec.Size = new System.Drawing.Size(280, 21);
            this.cboCodec.TabIndex = 7;
            this.cboCodec.SelectedIndexChanged += new System.EventHandler(this.cboCodec_SelectedIndexChanged);
            // 
            // lblStem
            // 
            this.lblStem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStem.Location = new System.Drawing.Point(391, 16);
            this.lblStem.Name = "lblStem";
            this.lblStem.Size = new System.Drawing.Size(280, 23);
            this.lblStem.TabIndex = 2;
            this.lblStem.Text = "Audio tracks to split:";
            this.lblStem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboStem
            // 
            this.cboStem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStem.FormattingEnabled = true;
            this.cboStem.Location = new System.Drawing.Point(391, 42);
            this.cboStem.Name = "cboStem";
            this.cboStem.Size = new System.Drawing.Size(280, 21);
            this.cboStem.TabIndex = 3;
            this.cboStem.SelectedIndexChanged += new System.EventHandler(this.cboStem_SelectedIndexChanged);
            // 
            // lblAiEngine
            // 
            this.lblAiEngine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAiEngine.Location = new System.Drawing.Point(105, 16);
            this.lblAiEngine.Name = "lblAiEngine";
            this.lblAiEngine.Size = new System.Drawing.Size(280, 23);
            this.lblAiEngine.TabIndex = 0;
            this.lblAiEngine.Text = "A.I. Engine (Machine Learning):";
            this.lblAiEngine.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboAiEngine
            // 
            this.cboAiEngine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAiEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAiEngine.FormattingEnabled = true;
            this.cboAiEngine.Location = new System.Drawing.Point(105, 42);
            this.cboAiEngine.Name = "cboAiEngine";
            this.cboAiEngine.Size = new System.Drawing.Size(280, 21);
            this.cboAiEngine.TabIndex = 1;
            this.cboAiEngine.SelectedIndexChanged += new System.EventHandler(this.cboAiEngine_SelectedIndexChanged);
            // 
            // chkSavePath
            // 
            this.chkSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSavePath.Location = new System.Drawing.Point(12, 534);
            this.chkSavePath.Name = "chkSavePath";
            this.chkSavePath.Size = new System.Drawing.Size(776, 24);
            this.chkSavePath.TabIndex = 7;
            this.chkSavePath.Text = "&Save Location (save files on source folder)";
            this.chkSavePath.UseVisualStyleBackColor = true;
            this.chkSavePath.CheckedChanged += new System.EventHandler(this.chkSavePath_CheckedChanged);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavePath.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSavePath.Location = new System.Drawing.Point(12, 564);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(695, 24);
            this.txtSavePath.TabIndex = 8;
            this.txtSavePath.TextChanged += new System.EventHandler(this.txtSavePath_TextChanged);
            this.txtSavePath.Leave += new System.EventHandler(this.txtSavePath_Leave);
            // 
            // btnSetSavePath
            // 
            this.btnSetSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetSavePath.Location = new System.Drawing.Point(713, 564);
            this.btnSetSavePath.Name = "btnSetSavePath";
            this.btnSetSavePath.Size = new System.Drawing.Size(75, 24);
            this.btnSetSavePath.TabIndex = 9;
            this.btnSetSavePath.Text = "&Browse...";
            this.btnSetSavePath.UseVisualStyleBackColor = true;
            this.btnSetSavePath.Click += new System.EventHandler(this.btnSetSavePath_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(604, 76);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 32);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblSplit1
            // 
            this.lblSplit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSplit1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSplit1.Location = new System.Drawing.Point(710, 76);
            this.lblSplit1.Name = "lblSplit1";
            this.lblSplit1.Size = new System.Drawing.Size(2, 32);
            this.lblSplit1.TabIndex = 10;
            // 
            // timerGetVersion
            // 
            this.timerGetVersion.Interval = 1000;
            this.timerGetVersion.Tick += new System.EventHandler(this.timerGetVersion_Tick);
            // 
            // lblSplit2
            // 
            this.lblSplit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSplit2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSplit2.Location = new System.Drawing.Point(88, 76);
            this.lblSplit2.Name = "lblSplit2";
            this.lblSplit2.Size = new System.Drawing.Size(2, 32);
            this.lblSplit2.TabIndex = 11;
            // 
            // lblLink
            // 
            this.lblLink.Enabled = false;
            this.lblLink.Location = new System.Drawing.Point(96, 76);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(300, 32);
            this.lblLink.TabIndex = 12;
            this.lblLink.Text = "© 2022 GiladLeef, Deezer, Google.";
            this.lblLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblSplit2);
            this.Controls.Add(this.lblSplit1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSetSavePath);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.chkSavePath);
            this.Controls.Add(this.gpbOptions);
            this.Controls.Add(this.lstFile);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnFileRemove);
            this.Controls.Add(this.btnFileAdd);
            this.Controls.Add(this.pbxBanner);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerfectPitcher: Split vocals & music tracks into separated tracks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBanner)).EndInit();
            this.gpbOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBanner;
        private System.Windows.Forms.Button btnFileAdd;
        private System.Windows.Forms.Button btnFileRemove;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListView lstFile;
        private System.Windows.Forms.GroupBox gpbOptions;
        private System.Windows.Forms.CheckBox chkSavePath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnSetSavePath;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader colFileDateMod;
        private System.Windows.Forms.ColumnHeader colFileType;
        private System.Windows.Forms.ColumnHeader colFileSize;
        private System.Windows.Forms.ColumnHeader colFileStatus;
        private System.Windows.Forms.ComboBox cboAiEngine;
        private System.Windows.Forms.Label lblAiEngine;
        private System.Windows.Forms.ComboBox cboStem;
        private System.Windows.Forms.Label lblStem;
        private System.Windows.Forms.ComboBox cboCodec;
        private System.Windows.Forms.Label lblCodec;
        private System.Windows.Forms.CheckBox chkMWF;
        private System.Windows.Forms.NumericUpDown nudOffset;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Label lblBitRate;
        private System.Windows.Forms.ComboBox cboBitRate;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblSplit1;
        private System.Windows.Forms.Timer timerGetVersion;
        private System.Windows.Forms.Label lblSplit2;
        private System.Windows.Forms.Label lblLink;
    }
}

