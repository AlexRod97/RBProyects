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

namespace SwineTracker
{
    public partial class Form1 : Form
    {
        Main dataStructure = new Main();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataStructure.Insert(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataStructure.Update(textBox2.Text, textBox1.Text);
            MessageBox.Show("Actualizado");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataStructure.Delete(textBox1.Text);
            MessageBox.Show("Eliminado");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SwineFabric fabric = new SwineFabric();
            fabric.Distribute(textBox1.Text);
        }
    }
}
