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

        public Login()
        {
            if (SwineTracker.Properties.Settings.Default.FirstRun == true)
            {
                SwineTracker.Properties.Settings.Default.FirstRun = false;
                SwineTracker.Properties.Settings.Default.FileDirectory = Environment.CurrentDirectory;
                SwineTracker.Properties.Settings.Default.Save();
                dataStructure.BuildDirectory(SwineTracker.Properties.Settings.Default.FileDirectory);
                //MessageBox.Show("Setting First: " + SwineTracker.Properties.Settings.Default.FileDirectory);
            }
            else
            {
                dataStructure.BuildDirectory(SwineTracker.Properties.Settings.Default.FileDirectory);
                //MessageBox.Show("Current: " + Environment.CurrentDirectory);
                //MessageBox.Show("Setting: " + SwineTracker.Properties.Settings.Default.FileDirectory);
            }
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
            //White.Height = this.Height;
            //White.Width = this.Width / 2;

            //Dark.Height = this.Height;
            //Dark.Width = this.Width / 2;

        }      

        private void Login_ResizeEnd(object sender, EventArgs e)
        {
            relocate();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Visible = false;
        }


        #region Hover-leave


        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginBtn_MouseHover(object sender, EventArgs e)
        {
            LoginBtn.Size = new Size(175, 55);  
        }

        private void LoginBtn_MouseLeave(object sender, EventArgs e)
        {
            LoginBtn.Size = new Size(170, 50);
        }
    }
}
