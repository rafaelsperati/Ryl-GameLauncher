using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using GameLauncher;
using System.Diagnostics;

namespace GameLauncher
{
	public partial class frmLauncher : AlphaForm
	{
		public frmLauncher()
		{
			InitializeComponent();
		}

        private Image m_closeBtnOff;
        private Image m_closeBtnOn;

        private Image m_BtnGameStartOff;
        private Image m_BtnGameStartOn;

        private Patcher oPatcher;
        private void GameLauncher_Load(object sender, EventArgs e)
        {
            DrawControlBackground(this.btnClose, false);
            DrawControlBackground(this.btnStartGame, false);
            DrawControlBackground(this.lblStatusText, false);
            UpdateLayeredBackground();

            //For convenience when switching between the on / off images
            m_closeBtnOff = this.btnClose.Image;
            m_closeBtnOn = this.btnClose.BackgroundImage;

            m_BtnGameStartOff = this.btnStartGame.Image;
            m_BtnGameStartOn = this.btnStartGame.BackgroundImage;

            this.oPatcher = new Patcher(this);
        }

        private void picBoxClose_MouseEnter(object sender, EventArgs e)
		{
			this.btnClose.Image = m_closeBtnOn;
			this.btnClose.BackgroundImage = m_closeBtnOff;
            this.btnClose.Cursor = Cursors.Hand;
        }

		private void picBoxClose_MouseLeave(object sender, EventArgs e)
		{
			this.btnClose.BackgroundImage = m_closeBtnOn;
			this.btnClose.Image = m_closeBtnOff;
            this.btnClose.Cursor = Cursors.Default;
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStartGame_MouseEnter(object sender, EventArgs e)
        {
            this.btnStartGame.Image = m_BtnGameStartOn;
            this.btnStartGame.BackgroundImage = m_BtnGameStartOff;
            this.btnStartGame.Cursor = Cursors.Hand;
        }

        private void btnStartGame_MouseLeave(object sender, EventArgs e)
        {
            this.btnStartGame.BackgroundImage = m_BtnGameStartOn;
            this.btnStartGame.Image = m_BtnGameStartOff;
            this.btnStartGame.Cursor = Cursors.Default;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            try
            {
                //Save environment path
                string currentDirectory = Environment.CurrentDirectory;

                string execute = string.Concat(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, "\\", this.oPatcher.getClientPath());
                string execute_path = System.IO.Path.GetDirectoryName(execute);

                Environment.CurrentDirectory = execute_path;

                ProcessStartInfo startInfo = new ProcessStartInfo(execute);
                startInfo.Arguments = this.oPatcher.getClientParameters();
                startInfo.UseShellExecute = true;
                Process.Start(startInfo);

                // restore the selected directory locally.   
                Environment.CurrentDirectory = currentDirectory;
                this.Close();
            } catch (Exception ex)
            {
                this.oPatcher.setStatusText(ex.Message);
            }
        }
    }
}
