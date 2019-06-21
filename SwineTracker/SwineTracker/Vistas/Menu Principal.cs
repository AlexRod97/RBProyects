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
           // Relocate();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnRemplazos_Click(object sender, EventArgs e)
        {
            Vistas.Ingreso_de_Reemplazos s = new Vistas.Ingreso_de_Reemplazos();
            s.Show();
            this.Visible = false;
        }

        private void btnInseminacion_Click(object sender, EventArgs e)
        {
            Vistas.Actividad actividad = new Vistas.Actividad();
            actividad.Show();
            this.Visible = false;
        }

        private void btnFichas_Click(object sender, EventArgs e)
        {
            Vistas.FichasHembras fh = new Vistas.FichasHembras();
            fh.Show();
            this.Visible = false;

        }

        private void btnComparativaH_Click(object sender, EventArgs e)
        {
            Vistas.Comparativa_por_hembra ch = new Vistas.Comparativa_por_hembra();
            ch.Show();
            this.Visible = false;
        }

        private void btnComparativaF_Click(object sender, EventArgs e)
        {
            Vistas.Comparativa_por_fechas cf = new Vistas.Comparativa_por_fechas();
            cf.Show();
            this.Visible = false;
        }

        private void btnFechaConfirmacion_Click(object sender, EventArgs e)
        {
            Vistas.Fechas_de_confirmacion fc = new Vistas.Fechas_de_confirmacion();
            fc.Show();
            this.Visible = false;
        }

        private void btnProyeccion_Click(object sender, EventArgs e)
        {
            Vistas.Proyeccion_de_partos pp = new Vistas.Proyeccion_de_partos();
            pp.Show();
            this.Visible = false;
        }

        private void btnDestete_Click(object sender, EventArgs e)
        {

        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            Vistas.Notificaciones n = new Vistas.Notificaciones();
            n.Show();
            this.Visible = false;
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {

        }


        private void btnSesion_Click(object sender, EventArgs e)
        {
            Vistas.Login sw = new Vistas.Login();
            sw.Show();
            this.Visible = false;
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Importador de base de datos";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.DefaultExt = "csv";

            openFileDialog1.ShowDialog();


            String direccion = openFileDialog1.FileName;

        }

        private void btnExportarDatos_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Exportador de base de datos";
            openFileDialog1.ShowDialog();
        }

        private void Relocate()
        {
            HeaderPanel.Left = (this.ClientSize.Width - HeaderPanel.Width) / 2 ;
            HeaderPanel.Top = (this.ClientSize.Height - HeaderPanel.Height) / 2 -125;

            Logo.Top = (this.ClientSize.Width /4 - Logo.Height) - 250;
            Logo.BringToFront();

            FooterPanel.Left = (this.ClientSize.Width - FooterPanel.Width) / 2;
            FooterPanel.Top = (this.ClientSize.Height - FooterPanel.Height) / 2 + 50;

            btnCargarDatos.Top = (this.ClientSize.Height - 165);
            btnSesion.Top = (this.ClientSize.Height - 100);
            btnSesion.Left = (this.ClientSize.Width - 207);
            btnExportarDatos.Top = (this.ClientSize.Height - 100);
        }

        #region Hover-Leave

        private void BtnRemplazos_MouseHover(object sender, EventArgs e)
        {
            BtnRemplazos.Size = new Size(200, 125);
        }

        private void btnInseminacion_MouseHover(object sender, EventArgs e)
        {
            btnInseminacion.Size = new Size(200, 125);
        }

        private void btnFichas_MouseHover(object sender, EventArgs e)
        {
            btnFichas.Size = new Size(200, 125);
        }

        private void btnComparativaH_MouseHover(object sender, EventArgs e)
        {
            btnComparativaH.Size = new Size(200, 125);
        }

        private void btnComparativaF_MouseHover(object sender, EventArgs e)
        {
            btnComparativaF.Size = new Size(200, 125);
        }

        private void btnFechaConfirmacion_MouseHover(object sender, EventArgs e)
        {
            btnFechaConfirmacion.Size = new Size(200, 125);
        }

        private void btnProyeccion_MouseHover(object sender, EventArgs e)
        {
            btnProyeccion.Size = new Size(200, 125);
        }

        private void btnDestete_MouseHover(object sender, EventArgs e)
        {
            btnDestete.Size = new Size(200, 125);
        }

        private void btnNotificaciones_MouseHover(object sender, EventArgs e)
        {
            btnNotificaciones.Size = new Size(200, 125);
        }

        private void btnBajas_MouseHover(object sender, EventArgs e)
        {
            btnBajas.Size = new Size(200, 125);
        }

        private void btnCargarDatos_MouseHover(object sender, EventArgs e)
        {
            btnCargarDatos.Size = new Size(200, 70);
        }

        private void btnExportarDatos_MouseHover(object sender, EventArgs e)
        {
            btnExportarDatos.Size = new Size(200, 70);
        }

        private void btnSesion_MouseHover(object sender, EventArgs e)
        {
            btnSesion.Size = new Size(170, 70);
        }

        private void BtnRemplazos_MouseLeave(object sender, EventArgs e)
        {
            BtnRemplazos.Size = new Size(195, 120);
        }

        private void btnInseminacion_MouseLeave(object sender, EventArgs e)
        {
            btnInseminacion.Size = new Size(195, 120);
        }

        private void btnFichas_MouseLeave(object sender, EventArgs e)
        {
            btnFichas.Size = new Size(195, 120);
        }

        private void btnComparativaH_MouseLeave(object sender, EventArgs e)
        {
            btnComparativaH.Size = new Size(195, 120);
        }

        private void btnComparativaF_MouseLeave(object sender, EventArgs e)
        {
            btnComparativaF.Size = new Size(195, 120);
        }

        private void btnFechaConfirmacion_MouseLeave(object sender, EventArgs e)
        {
            btnFechaConfirmacion.Size = new Size(195, 120);
        }

        private void btnProyeccion_MouseLeave(object sender, EventArgs e)
        {
            btnProyeccion.Size = new Size(195, 120);
        }

        private void btnDestete_MouseLeave(object sender, EventArgs e)
        {
            btnDestete.Size = new Size(195, 120);
        }

        private void btnNotificaciones_MouseLeave(object sender, EventArgs e)
        {
            btnNotificaciones.Size = new Size(195, 120);
        }

        private void btnBajas_MouseLeave(object sender, EventArgs e)
        {
            btnBajas.Size = new Size(195, 120);
        }

        private void btnCargarDatos_MouseLeave(object sender, EventArgs e)
        {
            btnCargarDatos.Size = new Size(195, 65);
        }

        private void btnExportarDatos_MouseLeave(object sender, EventArgs e)
        {
            btnExportarDatos.Size = new Size(195, 65);
        }

        private void btnSesion_MouseLeave(object sender, EventArgs e)
        {
            btnSesion.Size = new Size(165, 65);
        }

        #endregion

        private void MenuPrincipal_Resize(object sender, EventArgs e)
        {
            Relocate();
        }
    }
}
