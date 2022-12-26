
namespace PerfectPitcher
{
    partial class frmAbout
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.pbxBannner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBannner)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "P E R F E C T P I T C H E R";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCopyright.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(12, 539);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(376, 32);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "© 2022 GiladLeef, Deezer, Google." +
    "\n";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblLink
            // 
            this.lblLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLink.BackColor = System.Drawing.Color.Transparent;
            this.lblLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLink.Location = new System.Drawing.Point(12, 41);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(376, 20);
            this.lblLink.TabIndex = 3;
            this.lblLink.Text = "https://github.com/GiladLeef/PerfectPitcher";
            this.lblLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxBannner
            // 
            this.pbxBannner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxBannner.Cursor = System.Windows.Forms.Cursors.Help;
            this.pbxBannner.Image = global::PerfectPitcher.Properties.Resources.AboutBG;
            this.pbxBannner.Location = new System.Drawing.Point(0, 74);
            this.pbxBannner.Name = "pbxBannner";
            this.pbxBannner.Size = new System.Drawing.Size(400, 450);
            this.pbxBannner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBannner.TabIndex = 4;
            this.pbxBannner.TabStop = false;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(400, 580);
            this.Controls.Add(this.pbxBannner);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About PerfectPitcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAbout_FormClosed);
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.Shown += new System.EventHandler(this.frmAbout_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBannner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.PictureBox pbxBannner;
    }
}