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
using SwineTracker.Data_Structure;

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
            Swine swine = new Swine();
            Main main = new Main();

            swine.setArete(txtHembra.Text);
            swine.setFechaIngreso(txtFechaIngreso.Text);
            swine.setfechaNacimiento(txtFechaNacimiento.Text);
            main.Insert(swine.ConvertString());
        }
    }
}
