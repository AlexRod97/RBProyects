using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwineTracker.Data_Structure;
using SwineTracker.DataStructure;

namespace SwineTracker.Vistas
{
    public partial class Admin : Form
    {
        Main dataStructure = new Main();
        
        public Form1()
        public Admin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SwineTracker.Properties.Settings.Default.Reset();

            if (SwineTracker.Properties.Settings.Default.FirstRun == true)
            {
                SwineTracker.Properties.Settings.Default.FirstRun = false;
                SwineTracker.Properties.Settings.Default.FileDirectory = Environment.CurrentDirectory;
                SwineTracker.Properties.Settings.Default.Save();
                dataStructure.BuildDirectory(SwineTracker.Properties.Settings.Default.FileDirectory);
                //MessageBox.Show("Current First: " + Environment.CurrentDirectory);
                //MessageBox.Show("Setting First: " + SwineTracker.Properties.Settings.Default.FileDirectory);
            }
            else
            {
                dataStructure.BuildDirectory(SwineTracker.Properties.Settings.Default.FileDirectory);
                //MessageBox.Show("Current: " + Environment.CurrentDirectory);
                //MessageBox.Show("Setting: " + SwineTracker.Properties.Settings.Default.FileDirectory);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataStructure.Insert(textBox1.Text);
            MessageBox.Show("Guardado");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataStructure.Update(textBox2.Text);
            MessageBox.Show("Actualizado");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataStructure.Delete(textBox2.Text);
            MessageBox.Show("Eliminado");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SwineFabric fabric = new SwineFabric();
            Swine swine = new Swine(); 

            swine = fabric.Distribute(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Swine> result = new List<Swine>();
            result = dataStructure.BuscarPorArete(textBox3.Text);
            MessageBox.Show("Busqueda terminó");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Seleccionar ruta de almacenamiento";
            textBox4.Text = SwineTracker.Properties.Settings.Default.FileDirectory;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                SwineTracker.Properties.Settings.Default.FileDirectory = folderBrowserDialog1.SelectedPath;
                SwineTracker.Properties.Settings.Default.Save();
                textBox4.Text = SwineTracker.Properties.Settings.Default.FileDirectory;
            }
        }
    }
}
