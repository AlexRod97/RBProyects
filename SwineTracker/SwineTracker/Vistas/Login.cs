using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwineTracker.DataStructure;

namespace SwineTracker.Vistas
{
    public partial class Login : Form
    {
        Main dataStructure = new Main();
        bool flag = true;

        public Login()
        {
            if (SwineTracker.Properties.Settings.Default.FirstRun == true)
            {
                SwineTracker.Properties.Settings.Default.FirstRun = false;
                SwineTracker.Properties.Settings.Default.FileDirectory = Environment.CurrentDirectory;
                SwineTracker.Properties.Settings.Default.Save();
                dataStructure.BuildDirectory(SwineTracker.Properties.Settings.Default.FileDirectory);
            }
            else
            {
                dataStructure.BuildDirectory(SwineTracker.Properties.Settings.Default.FileDirectory);              
            }
            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.WorkingArea.Height);

            InitializeComponent();          
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            relocate();
        } 

        public void relocate()
        {
            CredentialsPanel.Left = (this.ClientSize.Width / 2 - CredentialsPanel.Width) / 2;
            CredentialsPanel.Top = (this.ClientSize.Height - CredentialsPanel.Height) / 2;


            Logo.Left = (this.ClientSize.Width / 2 - Logo.Width) / 2 + this.ClientSize.Width / 2;
            Logo.Top = (this.ClientSize.Height - Logo.Height) / 2;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }        

        #region Hover-leave

        private void btnMax_Click(object sender, EventArgs e)
        {
            if(flag)
            {
                this.WindowState = FormWindowState.Maximized;
                flag = !flag;
            }
            else
            {
                this.MinimizeBox = true;
                flag = !flag;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginBtn_MouseHover(object sender, EventArgs e)
        {
            LoginBtn.Size = new Size(185, 55);  
        }

        private void LoginBtn_MouseLeave(object sender, EventArgs e)
        {
            LoginBtn.Size = new Size(180, 50);
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            relocate();
        }

        #endregion

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Visible = false;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
            btnClose.Size = new Size(30,30);
        }

        private void btnMax_MouseHover(object sender, EventArgs e)
        {
            btnMax.BackColor = Color.LightGray;
            btnMax.Size = new Size(30, 30);
        }

        private void btnMin_MouseHover(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.LightGray;
            btnMin.Size = new Size(30, 30);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
            btnClose.Size = new Size(25, 25);
        }

        private void btnMax_MouseLeave(object sender, EventArgs e)
        {
            btnMax.BackColor = Color.Transparent;
            btnMax.Size = new Size(25, 25);
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.Transparent;
            btnMin.Size = new Size(25, 25);
        }
    }
}
