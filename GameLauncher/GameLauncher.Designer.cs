namespace GameLauncher
{
    partial class frmLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLauncher));
            this.lblStatusText = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.ctrlProgressBar = new ColorProgressBar.ColorProgressBar();
            this.newsWebbrowser = new System.Windows.Forms.WebBrowser();
            this.lblDownloadSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatusText
            // 
            this.lblStatusText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusText.ForeColor = System.Drawing.Color.White;
            this.lblStatusText.Location = new System.Drawing.Point(21, 404);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(461, 18);
            this.lblStatusText.TabIndex = 3;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStartGame.Enabled = false;
            this.btnStartGame.Location = new System.Drawing.Point(512, 403);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(126, 40);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.TabStop = false;
            this.btnStartGame.Visible = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            this.btnStartGame.MouseEnter += new System.EventHandler(this.btnStartGame_MouseEnter);
            this.btnStartGame.MouseLeave += new System.EventHandler(this.btnStartGame_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Location = new System.Drawing.Point(597, 544);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(53, 24);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.picBoxClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.picBoxClose_MouseLeave);
            // 
            // ctrlProgressBar
            // 
            this.ctrlProgressBar.BackgroundColor = System.Drawing.Color.Empty;
            this.ctrlProgressBar.BarColor = System.Drawing.Color.Empty;
            this.ctrlProgressBar.BorderColor = System.Drawing.Color.Empty;
            this.ctrlProgressBar.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Solid;
            this.ctrlProgressBar.Location = new System.Drawing.Point(21, 429);
            this.ctrlProgressBar.Maximum = 100;
            this.ctrlProgressBar.Minimum = 0;
            this.ctrlProgressBar.Name = "ctrlProgressBar";
            this.ctrlProgressBar.Size = new System.Drawing.Size(461, 14);
            this.ctrlProgressBar.Step = 10;
            this.ctrlProgressBar.TabIndex = 4;
            this.ctrlProgressBar.Value = 0;
            // 
            // newsWebbrowser
            // 
            this.newsWebbrowser.Location = new System.Drawing.Point(15, 29);
            this.newsWebbrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.newsWebbrowser.Name = "newsWebbrowser";
            this.newsWebbrowser.Size = new System.Drawing.Size(626, 336);
            this.newsWebbrowser.TabIndex = 5;
            // 
            // lblDownloadSpeed
            // 
            this.lblDownloadSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(139)))), ((int)(((byte)(194)))));
            this.lblDownloadSpeed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownloadSpeed.ForeColor = System.Drawing.Color.White;
            this.lblDownloadSpeed.Location = new System.Drawing.Point(480, 486);
            this.lblDownloadSpeed.Name = "lblDownloadSpeed";
            this.lblDownloadSpeed.Size = new System.Drawing.Size(67, 22);
            this.lblDownloadSpeed.TabIndex = 6;
            this.lblDownloadSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmLauncher
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BlendedBackground = ((System.Drawing.Bitmap)(resources.GetObject("$this.BlendedBackground")));
            this.ClientSize = new System.Drawing.Size(662, 580);
            this.Controls.Add(this.lblDownloadSpeed);
            this.Controls.Add(this.newsWebbrowser);
            this.Controls.Add(this.ctrlProgressBar);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnClose);
            this.DrawControlBackgrounds = true;
            this.EnhancedRendering = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLauncher";
            this.SizeMode = GameLauncher.AlphaForm.SizeModes.Clip;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROW Launcher";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.GameLauncher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnStartGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        public System.Windows.Forms.PictureBox btnStartGame;
        public System.Windows.Forms.Label lblStatusText;
        public ColorProgressBar.ColorProgressBar ctrlProgressBar;
        public System.Windows.Forms.WebBrowser newsWebbrowser;
        public System.Windows.Forms.Label lblDownloadSpeed;
    }
}

