using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class frmSplashScreen : Form
    {
        private BackgroundWorker2 bgThread = new BackgroundWorker2();

        public frmSplashScreen()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            bgThread.DoWork += BgThread_DoWork;
            bgThread.RunWorkerCompleted += BgThread_RunWorkerCompleted;
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            BackgroundImage = PerfectPitcher.Properties.Resources.SplashScreen;
        }

        private void frmSplashScreen_Shown(object sender, EventArgs e)
        {
            bgThread.RunWorkerAsync();
        }

        private void BgThread_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(new Random().Next(1000, 5000));

            while (Opacity > 0)
            {
                BeginInvoke((Action)delegate ()
                {
                    Opacity -= 0.02;
                });

                Thread.Sleep(1);
            }
        }

        private void BgThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }
    }
}
