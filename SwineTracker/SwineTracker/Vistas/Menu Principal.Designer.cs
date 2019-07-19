namespace SwineTracker
{
    public partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.btnFichaHembra = new System.Windows.Forms.PictureBox();
            this.btnComparativaHembra = new System.Windows.Forms.PictureBox();
            this.btnInseminacion = new System.Windows.Forms.PictureBox();
            this.btnComparativaFecha = new System.Windows.Forms.PictureBox();
            this.btnReemplazos = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.WindowPanel = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.ExtrasPanel = new System.Windows.Forms.Panel();
            this.btnDescargarBd = new System.Windows.Forms.PictureBox();
            this.btnCargarBd = new System.Windows.Forms.PictureBox();
            this.btnSesion = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.btnDestete = new System.Windows.Forms.PictureBox();
            this.btnNotificaciones = new System.Windows.Forms.PictureBox();
            this.btnFechaConfirmacion = new System.Windows.Forms.PictureBox();
            this.btnProyeccionParto = new System.Windows.Forms.PictureBox();
            this.btnBajas = new System.Windows.Forms.PictureBox();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFichaHembra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComparativaHembra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInseminacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComparativaFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReemplazos)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.WindowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.ExtrasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargarBd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCargarBd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDestete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechaConfirmacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProyeccionParto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBajas)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Excel";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HeaderPanel.Controls.Add(this.btnFichaHembra);
            this.HeaderPanel.Controls.Add(this.btnComparativaHembra);
            this.HeaderPanel.Controls.Add(this.btnInseminacion);
            this.HeaderPanel.Controls.Add(this.btnComparativaFecha);
            this.HeaderPanel.Controls.Add(this.btnReemplazos);
            this.HeaderPanel.Location = new System.Drawing.Point(35, 130);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1080, 160);
            this.HeaderPanel.TabIndex = 46;
            // 
            // btnFichaHembra
            // 
            this.btnFichaHembra.BackColor = System.Drawing.Color.White;
            this.btnFichaHembra.Image = global::SwineTracker.Properties.Resources.fichashembras;
            this.btnFichaHembra.Location = new System.Drawing.Point(440, 20);
            this.btnFichaHembra.Name = "btnFichaHembra";
            this.btnFichaHembra.Size = new System.Drawing.Size(195, 120);
            this.btnFichaHembra.TabIndex = 55;
            this.btnFichaHembra.TabStop = false;
            this.btnFichaHembra.Click += new System.EventHandler(this.btnFichaHembra_Click);
            this.btnFichaHembra.MouseLeave += new System.EventHandler(this.btnFichaHembra_MouseLeave);
            this.btnFichaHembra.MouseHover += new System.EventHandler(this.btnFichaHembra_MouseHover);
            // 
            // btnComparativaHembra
            // 
            this.btnComparativaHembra.BackColor = System.Drawing.Color.White;
            this.btnComparativaHembra.Image = global::SwineTracker.Properties.Resources.comparativahembra;
            this.btnComparativaHembra.Location = new System.Drawing.Point(660, 20);
            this.btnComparativaHembra.Name = "btnComparativaHembra";
            this.btnComparativaHembra.Size = new System.Drawing.Size(195, 120);
            this.btnComparativaHembra.TabIndex = 54;
            this.btnComparativaHembra.TabStop = false;
            this.btnComparativaHembra.Click += new System.EventHandler(this.btnComparativaHembra_Click);
            this.btnComparativaHembra.MouseLeave += new System.EventHandler(this.btnComparativaHembra_MouseLeave);
            this.btnComparativaHembra.MouseHover += new System.EventHandler(this.btnComparativaHembra_MouseHover);
            // 
            // btnInseminacion
            // 
            this.btnInseminacion.BackColor = System.Drawing.Color.White;
            this.btnInseminacion.Image = global::SwineTracker.Properties.Resources.agregarPartoInseminacion;
            this.btnInseminacion.Location = new System.Drawing.Point(220, 20);
            this.btnInseminacion.Name = "btnInseminacion";
            this.btnInseminacion.Size = new System.Drawing.Size(195, 120);
            this.btnInseminacion.TabIndex = 53;
            this.btnInseminacion.TabStop = false;
            this.btnInseminacion.Click += new System.EventHandler(this.btnInseminacion_Click);
            this.btnInseminacion.MouseLeave += new System.EventHandler(this.btnInseminacion_MouseLeave);
            this.btnInseminacion.MouseHover += new System.EventHandler(this.btnInseminacion_MouseHover);
            // 
            // btnComparativaFecha
            // 
            this.btnComparativaFecha.BackColor = System.Drawing.Color.White;
            this.btnComparativaFecha.Image = global::SwineTracker.Properties.Resources.comparativaFechas;
            this.btnComparativaFecha.Location = new System.Drawing.Point(880, 20);
            this.btnComparativaFecha.Name = "btnComparativaFecha";
            this.btnComparativaFecha.Size = new System.Drawing.Size(195, 120);
            this.btnComparativaFecha.TabIndex = 52;
            this.btnComparativaFecha.TabStop = false;
            this.btnComparativaFecha.Click += new System.EventHandler(this.btnComparativaFecha_Click);
            this.btnComparativaFecha.MouseLeave += new System.EventHandler(this.btnComparativaFecha_MouseLeave);
            this.btnComparativaFecha.MouseHover += new System.EventHandler(this.btnComparativaFecha_MouseHover);
            // 
            // btnReemplazos
            // 
            this.btnReemplazos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReemplazos.BackColor = System.Drawing.Color.White;
            this.btnReemplazos.Image = global::SwineTracker.Properties.Resources.ingresoRemplazos;
            this.btnReemplazos.Location = new System.Drawing.Point(0, 20);
            this.btnReemplazos.Name = "btnReemplazos";
            this.btnReemplazos.Size = new System.Drawing.Size(195, 120);
            this.btnReemplazos.TabIndex = 51;
            this.btnReemplazos.TabStop = false;
            this.btnReemplazos.Click += new System.EventHandler(this.btnReemplazos_Click);
            this.btnReemplazos.MouseLeave += new System.EventHandler(this.btnReemplazos_MouseLeave);
            this.btnReemplazos.MouseHover += new System.EventHandler(this.btnReemplazos_MouseHover);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.WindowPanel);
            this.MainPanel.Controls.Add(this.ExtrasPanel);
            this.MainPanel.Controls.Add(this.Logo);
            this.MainPanel.Controls.Add(this.BottomPanel);
            this.MainPanel.Controls.Add(this.HeaderPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1132, 610);
            this.MainPanel.TabIndex = 0;
            // 
            // WindowPanel
            // 
            this.WindowPanel.Controls.Add(this.btnMin);
            this.WindowPanel.Controls.Add(this.btnClose);
            this.WindowPanel.Location = new System.Drawing.Point(1035, 3);
            this.WindowPanel.Name = "WindowPanel";
            this.WindowPanel.Size = new System.Drawing.Size(94, 34);
            this.WindowPanel.TabIndex = 64;
            // 
            // btnMin
            // 
            this.btnMin.Image = global::SwineTracker.Properties.Resources.minimizar;
            this.btnMin.Location = new System.Drawing.Point(34, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMin.TabIndex = 66;
            this.btnMin.TabStop = false;
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            this.btnMin.MouseHover += new System.EventHandler(this.btnMin_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::SwineTracker.Properties.Resources.cerrar;
            this.btnClose.Location = new System.Drawing.Point(65, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 64;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // ExtrasPanel
            // 
            this.ExtrasPanel.BackColor = System.Drawing.Color.Transparent;
            this.ExtrasPanel.Controls.Add(this.btnDescargarBd);
            this.ExtrasPanel.Controls.Add(this.btnCargarBd);
            this.ExtrasPanel.Controls.Add(this.btnSesion);
            this.ExtrasPanel.Location = new System.Drawing.Point(35, 477);
            this.ExtrasPanel.Name = "ExtrasPanel";
            this.ExtrasPanel.Size = new System.Drawing.Size(1086, 121);
            this.ExtrasPanel.TabIndex = 61;
            // 
            // btnDescargarBd
            // 
            this.btnDescargarBd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDescargarBd.BackColor = System.Drawing.Color.Transparent;
            this.btnDescargarBd.Image = global::SwineTracker.Properties.Resources.exportardb;
            this.btnDescargarBd.Location = new System.Drawing.Point(3, 65);
            this.btnDescargarBd.Name = "btnDescargarBd";
            this.btnDescargarBd.Size = new System.Drawing.Size(180, 50);
            this.btnDescargarBd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDescargarBd.TabIndex = 59;
            this.btnDescargarBd.TabStop = false;
            this.btnDescargarBd.Click += new System.EventHandler(this.btnDescargarBd_Click);
            this.btnDescargarBd.MouseLeave += new System.EventHandler(this.btnDescargarBd_MouseLeave);
            this.btnDescargarBd.MouseHover += new System.EventHandler(this.btnDescargarBd_MouseHover);
            // 
            // btnCargarBd
            // 
            this.btnCargarBd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCargarBd.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarBd.Image = global::SwineTracker.Properties.Resources.cargardb;
            this.btnCargarBd.Location = new System.Drawing.Point(3, 3);
            this.btnCargarBd.Name = "btnCargarBd";
            this.btnCargarBd.Size = new System.Drawing.Size(180, 50);
            this.btnCargarBd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCargarBd.TabIndex = 58;
            this.btnCargarBd.TabStop = false;
            this.btnCargarBd.Click += new System.EventHandler(this.btnCargarBd_Click);
            this.btnCargarBd.MouseLeave += new System.EventHandler(this.btnCargarBd_MouseLeave);
            this.btnCargarBd.MouseHover += new System.EventHandler(this.btnCargarBd_MouseHover);
            // 
            // btnSesion
            // 
            this.btnSesion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnSesion.Image = global::SwineTracker.Properties.Resources.cerrarsesion;
            this.btnSesion.Location = new System.Drawing.Point(900, 65);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(180, 50);
            this.btnSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSesion.TabIndex = 57;
            this.btnSesion.TabStop = false;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            this.btnSesion.MouseLeave += new System.EventHandler(this.btnSesion_MouseLeave);
            this.btnSesion.MouseHover += new System.EventHandler(this.btnSesion_MouseHover);
            // 
            // Logo
            // 
            this.Logo.Image = global::SwineTracker.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(417, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(350, 120);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 56;
            this.Logo.TabStop = false;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.btnDestete);
            this.BottomPanel.Controls.Add(this.btnNotificaciones);
            this.BottomPanel.Controls.Add(this.btnFechaConfirmacion);
            this.BottomPanel.Controls.Add(this.btnProyeccionParto);
            this.BottomPanel.Controls.Add(this.btnBajas);
            this.BottomPanel.Location = new System.Drawing.Point(35, 320);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1086, 152);
            this.BottomPanel.TabIndex = 47;
            // 
            // btnDestete
            // 
            this.btnDestete.BackColor = System.Drawing.Color.White;
            this.btnDestete.Image = global::SwineTracker.Properties.Resources.destete;
            this.btnDestete.Location = new System.Drawing.Point(440, 17);
            this.btnDestete.Name = "btnDestete";
            this.btnDestete.Size = new System.Drawing.Size(195, 120);
            this.btnDestete.TabIndex = 60;
            this.btnDestete.TabStop = false;
            this.btnDestete.Click += new System.EventHandler(this.btnDestete_Click);
            this.btnDestete.MouseLeave += new System.EventHandler(this.btnDestete_MouseLeave);
            this.btnDestete.MouseHover += new System.EventHandler(this.btnDestete_MouseHover);
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.BackColor = System.Drawing.Color.White;
            this.btnNotificaciones.Image = global::SwineTracker.Properties.Resources.notificaciones;
            this.btnNotificaciones.Location = new System.Drawing.Point(660, 17);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Size = new System.Drawing.Size(195, 120);
            this.btnNotificaciones.TabIndex = 59;
            this.btnNotificaciones.TabStop = false;
            this.btnNotificaciones.Click += new System.EventHandler(this.btnNotificaciones_Click);
            this.btnNotificaciones.MouseLeave += new System.EventHandler(this.btnNotificaciones_MouseLeave);
            this.btnNotificaciones.MouseHover += new System.EventHandler(this.btnNotificaciones_MouseHover);
            // 
            // btnFechaConfirmacion
            // 
            this.btnFechaConfirmacion.BackColor = System.Drawing.Color.White;
            this.btnFechaConfirmacion.Image = global::SwineTracker.Properties.Resources.fechasConfirmacion;
            this.btnFechaConfirmacion.Location = new System.Drawing.Point(0, 17);
            this.btnFechaConfirmacion.Name = "btnFechaConfirmacion";
            this.btnFechaConfirmacion.Size = new System.Drawing.Size(195, 120);
            this.btnFechaConfirmacion.TabIndex = 56;
            this.btnFechaConfirmacion.TabStop = false;
            this.btnFechaConfirmacion.Click += new System.EventHandler(this.btnFechaConfirmacion_Click);
            this.btnFechaConfirmacion.MouseLeave += new System.EventHandler(this.btnFechaConfirmacion_MouseLeave);
            this.btnFechaConfirmacion.MouseHover += new System.EventHandler(this.btnFechaConfirmacion_MouseHover);
            // 
            // btnProyeccionParto
            // 
            this.btnProyeccionParto.BackColor = System.Drawing.Color.White;
            this.btnProyeccionParto.Image = global::SwineTracker.Properties.Resources.proyeccionpartos;
            this.btnProyeccionParto.Location = new System.Drawing.Point(220, 17);
            this.btnProyeccionParto.Name = "btnProyeccionParto";
            this.btnProyeccionParto.Size = new System.Drawing.Size(195, 120);
            this.btnProyeccionParto.TabIndex = 58;
            this.btnProyeccionParto.TabStop = false;
            this.btnProyeccionParto.Click += new System.EventHandler(this.btnProyeccionParto_Click);
            this.btnProyeccionParto.MouseLeave += new System.EventHandler(this.btnProyeccionParto_MouseLeave);
            this.btnProyeccionParto.MouseHover += new System.EventHandler(this.btnProyeccionParto_MouseHover);
            // 
            // btnBajas
            // 
            this.btnBajas.BackColor = System.Drawing.Color.White;
            this.btnBajas.Image = global::SwineTracker.Properties.Resources.dardebaja;
            this.btnBajas.Location = new System.Drawing.Point(880, 17);
            this.btnBajas.Name = "btnBajas";
            this.btnBajas.Size = new System.Drawing.Size(195, 120);
            this.btnBajas.TabIndex = 57;
            this.btnBajas.TabStop = false;
            this.btnBajas.Click += new System.EventHandler(this.btnBajas_Click);
            this.btnBajas.MouseLeave += new System.EventHandler(this.btnBajas_MouseLeave);
            this.btnBajas.MouseHover += new System.EventHandler(this.btnBajas_MouseHover);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1132, 610);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFichaHembra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComparativaHembra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInseminacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComparativaFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReemplazos)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.WindowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ExtrasPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDescargarBd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCargarBd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDestete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechaConfirmacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProyeccionParto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBajas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.PictureBox btnFichaHembra;
        private System.Windows.Forms.PictureBox btnComparativaHembra;
        private System.Windows.Forms.PictureBox btnInseminacion;
        private System.Windows.Forms.PictureBox btnComparativaFecha;
        private System.Windows.Forms.PictureBox btnReemplazos;
        private System.Windows.Forms.PictureBox btnDestete;
        private System.Windows.Forms.PictureBox btnNotificaciones;
        private System.Windows.Forms.PictureBox btnFechaConfirmacion;
        private System.Windows.Forms.PictureBox btnProyeccionParto;
        private System.Windows.Forms.PictureBox btnBajas;
        private System.Windows.Forms.Panel ExtrasPanel;
        private System.Windows.Forms.PictureBox btnSesion;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel WindowPanel;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnDescargarBd;
        private System.Windows.Forms.PictureBox btnCargarBd;
    }
}

