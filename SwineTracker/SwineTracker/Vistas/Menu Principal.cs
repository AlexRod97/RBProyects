using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwineTracker
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vistas.FichasHembras fh = new Vistas.FichasHembras();
            fh.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vistas.Comparativa_por_hembra ch = new Vistas.Comparativa_por_hembra();
            ch.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vistas.Comparativa_por_fechas cf = new Vistas.Comparativa_por_fechas();
            cf.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vistas.Proyeccion_de_partos pp = new Vistas.Proyeccion_de_partos();
            pp.Show();
            this.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Vistas.Fechas_de_confirmacion fc = new Vistas.Fechas_de_confirmacion();
            fc.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vistas.Notificaciones n = new Vistas.Notificaciones();
            n.Show();
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vistas.Login s = new Vistas.Login();
            s.Show();
            this.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Vistas.Ingreso_de_Reemplazos s = new Vistas.Ingreso_de_Reemplazos();
            s.Show();
            this.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Vistas.Actividad actividad = new Vistas.Actividad();
            actividad.Show();
            this.Visible = false;

 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Importador de base de datos";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.DefaultExt = "csv";

            openFileDialog1.ShowDialog();
            

            String direccion = openFileDialog1.FileName;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Exportador de base de datos";
            openFileDialog1.ShowDialog();
        }
    }
}
