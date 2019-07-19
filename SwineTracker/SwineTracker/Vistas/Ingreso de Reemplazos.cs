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
    public partial class Ingreso_de_Reemplazos : Form
    {
        public Ingreso_de_Reemplazos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Visible = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Swine swine = new Swine();
            Main main = new Main();

            swine.setArete(txtHembra.Text.ToUpper());
            swine.setFechaIngreso(txtFechaIngreso.Text);
            swine.setfechaNacimiento(txtFechaNacimiento.Text);
            main.Insert(swine.ConvertString());
            MessageBox.Show("Ingreso exitoso");
            txtFechaIngreso.Clear();
            txtFechaNacimiento.Clear();
            txtHembra.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.LightGray;
            btnClose.Size = new Size(25, 25);
        }
        
        private void btnMin_MouseHover(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.LightGray;
            btnMin.Size = new Size(25, 25);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
            btnClose.Size = new Size(25, 25);
        }
      
        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.Transparent;
            btnMin.Size = new Size(25, 25);
        }
    }
}
