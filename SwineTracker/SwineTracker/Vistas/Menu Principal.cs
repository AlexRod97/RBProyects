using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwineTracker.Vistas;

namespace SwineTracker
{
    public partial class MenuPrincipal : Form
    {
        private bool flag = true;

        public MenuPrincipal()
        {
            InitializeComponent();
            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.WorkingArea.Height);
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
        }
     
        
        private void Relocate()
        {
            WindowPanel.Left = this.ClientSize.Width - WindowPanel.Width - 10;

            HeaderPanel.Left = (this.ClientSize.Width - HeaderPanel.Width) / 2;
            HeaderPanel.Top = HeaderPanel.Top + Logo.Top;

            Logo.Left = (this.ClientSize.Width - Logo.Width) / 2;
            Logo.Top = HeaderPanel.Height - (Logo.Height / 2);


            BottomPanel.Left = (this.ClientSize.Width - BottomPanel.Width) / 2;
            BottomPanel.Top = HeaderPanel.Top + BottomPanel.Height;

            ExtrasPanel.Width = this.ClientSize.Width - 50;
            ExtrasPanel.Left = (this.ClientSize.Width - ExtrasPanel.Width) / 2;
            ExtrasPanel.Top = (this.ClientSize.Height - 50) - ExtrasPanel.Height;            
        }

        private void btnReemplazos_Click(object sender, EventArgs e)
        {
            Vistas.Ingreso_de_Reemplazos s = new Vistas.Ingreso_de_Reemplazos();
            s.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close(); 
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Relocate();
        }

        private void btnInseminacion_Click(object sender, EventArgs e)
        {
            Vistas.Actividad actividad = new Vistas.Actividad();
            actividad.Show();
        }

        private void btnFichaHembra_Click(object sender, EventArgs e)
        {
            Vistas.FichasHembras fh = new Vistas.FichasHembras();
            fh.Show();
        }

        private void btnComparativaHembra_Click(object sender, EventArgs e)
        {
            Vistas.Comparativa_por_hembra ch = new Vistas.Comparativa_por_hembra();
            ch.Show();
        }

        private void btnComparativaFecha_Click(object sender, EventArgs e)
        {
            Vistas.Comparativa_por_fechas cf = new Vistas.Comparativa_por_fechas();
            cf.Show();
        }

        private void btnFechaConfirmacion_Click(object sender, EventArgs e)
        {
            Vistas.Fechas_de_confirmacion fc = new Vistas.Fechas_de_confirmacion();
            fc.Show();
        }

        private void btnProyeccionParto_Click(object sender, EventArgs e)
        {
            Vistas.Proyeccion_de_partos pp = new Vistas.Proyeccion_de_partos();
            pp.Show();
        }

        private void btnDestete_Click(object sender, EventArgs e)
        {

        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            Vistas.Notificaciones n = new Vistas.Notificaciones();
            n.Show();
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            DeBaja db = new DeBaja();
            db.Show();
        }

        private void btnCargarBd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Importador de base de datos";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.DefaultExt = "csv";

            openFileDialog1.ShowDialog();


            String direccion = openFileDialog1.FileName;
        }

        private void btnDescargarBd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Exportador de base de datos";
            openFileDialog1.ShowDialog();
        }

        #region Hover-Leave

        private void btnReemplazos_MouseHover(object sender, EventArgs e)
        {
            btnReemplazos.Size = new Size(200, 125);
        }

        private void btnInseminacion_MouseHover(object sender, EventArgs e)
        {
            btnInseminacion.Size = new Size(200, 125);
        }

        private void btnFichaHembra_MouseHover(object sender, EventArgs e)
        {
            btnFichaHembra.Size = new Size(200, 125);
        }

        private void btnComparativaHembra_MouseHover(object sender, EventArgs e)
        {
            btnComparativaHembra.Size = new Size(200, 125);
        }

        private void btnComparativaFecha_MouseHover(object sender, EventArgs e)
        {
            btnComparativaFecha.Size = new Size(200, 125);
        }

        private void btnFechaConfirmacion_MouseHover(object sender, EventArgs e)
        {
            btnFechaConfirmacion.Size = new Size(200, 125);
        }

        private void btnProyeccionParto_MouseHover(object sender, EventArgs e)
        {
            btnProyeccionParto.Size = new Size(200, 125);
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

        private void btnCargarBd_MouseHover(object sender, EventArgs e)
        {
            btnCargarBd.Size = new Size(200, 55);
        }

        private void btnDescargarBd_MouseHover(object sender, EventArgs e)
        {
            btnDescargarBd.Size = new Size(200, 55);
        }

        private void btnSesion_MouseHover(object sender, EventArgs e)
        {
            btnSesion.Size = new Size(185, 55);
        }

        private void btnReemplazos_MouseLeave(object sender, EventArgs e)
        {
            btnReemplazos.Size = new Size(195, 120); 
        }

        private void btnInseminacion_MouseLeave(object sender, EventArgs e)
        {
            btnInseminacion.Size = new Size(195, 120);
        }

        private void btnFichaHembra_MouseLeave(object sender, EventArgs e)
        {
            btnFichaHembra.Size = new Size(195, 120);
        }

        private void btnComparativaHembra_MouseLeave(object sender, EventArgs e)
        {
            btnComparativaHembra.Size = new Size(195, 120);
        }

        private void btnComparativaFecha_MouseLeave(object sender, EventArgs e)
        {
            btnComparativaFecha.Size = new Size(195, 120);
        }

        private void btnFechaConfirmacion_MouseLeave(object sender, EventArgs e)
        {
            btnFechaConfirmacion.Size = new Size(195, 120);
        }

        private void btnProyeccionParto_MouseLeave(object sender, EventArgs e)
        {
           btnProyeccionParto.Size = new Size(195, 120);
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

        private void btnCargarBd_MouseLeave(object sender, EventArgs e)
        {
            btnCargarBd.Size = new Size(195, 50);
        }

        private void btnDescargarBd_MouseLeave(object sender, EventArgs e)
        {
            btnDescargarBd.Size = new Size(195, 50);
        }

        private void btnSesion_MouseLeave(object sender, EventArgs e)
        {
            btnSesion.Size = new Size(185, 50);
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.LightGray;
            btnClose.Size = new Size(30, 30);
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
       
        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.Transparent;
            btnMin.Size = new Size(25, 25);
        }

        #endregion
      
    }
}



