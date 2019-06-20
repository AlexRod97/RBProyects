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
    public partial class Login : MetroFramework.Forms.MetroForm
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

        private void button1_Click(object sender, EventArgs e)
        {
                    
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
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            //ParentPanel.Size = desktopSize;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Visible = false;
        }
    }
}
