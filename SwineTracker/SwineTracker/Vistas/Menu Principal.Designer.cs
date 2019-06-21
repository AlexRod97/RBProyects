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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSesion = new System.Windows.Forms.PictureBox();
            this.btnExportarDatos = new System.Windows.Forms.PictureBox();
            this.btnCargarDatos = new System.Windows.Forms.PictureBox();
            this.btnBajas = new System.Windows.Forms.PictureBox();
            this.btnNotificaciones = new System.Windows.Forms.PictureBox();
            this.btnDestete = new System.Windows.Forms.PictureBox();
            this.btnProyeccion = new System.Windows.Forms.PictureBox();
            this.btnFechaConfirmacion = new System.Windows.Forms.PictureBox();
            this.btnComparativaF = new System.Windows.Forms.PictureBox();
            this.btnComparativaH = new System.Windows.Forms.PictureBox();
            this.btnFichas = new System.Windows.Forms.PictureBox();
            this.btnInseminacion = new System.Windows.Forms.PictureBox();
            this.BtnRemplazos = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportarDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCargarDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDestete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProyeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechaConfirmacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComparativaF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComparativaH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFichas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInseminacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRemplazos)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Excel";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.btnSesion);
            this.MainPanel.Controls.Add(this.btnExportarDatos);
            this.MainPanel.Controls.Add(this.btnCargarDatos);
            this.MainPanel.Controls.Add(this.btnBajas);
            this.MainPanel.Controls.Add(this.btnNotificaciones);
            this.MainPanel.Controls.Add(this.btnDestete);
            this.MainPanel.Controls.Add(this.btnProyeccion);
            this.MainPanel.Controls.Add(this.btnFechaConfirmacion);
            this.MainPanel.Controls.Add(this.btnComparativaF);
            this.MainPanel.Controls.Add(this.btnComparativaH);
            this.MainPanel.Controls.Add(this.btnFichas);
            this.MainPanel.Controls.Add(this.btnInseminacion);
            this.MainPanel.Controls.Add(this.BtnRemplazos);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1132, 588);
            this.MainPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SwineTracker.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(421, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(958, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Dar de baja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(63, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ingreso de Reemplazos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(240, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Agregar Inseminación y/o Parto";
            // 
            // btnSesion
            // 
            this.btnSesion.Image = global::SwineTracker.Properties.Resources.cerrarSesion;
            this.btnSesion.Location = new System.Drawing.Point(925, 506);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(165, 65);
            this.btnSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSesion.TabIndex = 41;
            this.btnSesion.TabStop = false;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            this.btnSesion.MouseLeave += new System.EventHandler(this.btnSesion_MouseLeave);
            this.btnSesion.MouseHover += new System.EventHandler(this.btnSesion_MouseHover);
            // 
            // btnExportarDatos
            // 
            this.btnExportarDatos.Image = global::SwineTracker.Properties.Resources.exportarBase;
            this.btnExportarDatos.Location = new System.Drawing.Point(34, 506);
            this.btnExportarDatos.Name = "btnExportarDatos";
            this.btnExportarDatos.Size = new System.Drawing.Size(195, 65);
            this.btnExportarDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExportarDatos.TabIndex = 40;
            this.btnExportarDatos.TabStop = false;
            this.btnExportarDatos.Click += new System.EventHandler(this.btnExportarDatos_Click);
            this.btnExportarDatos.MouseLeave += new System.EventHandler(this.btnExportarDatos_MouseLeave);
            this.btnExportarDatos.MouseHover += new System.EventHandler(this.btnExportarDatos_MouseHover);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Image = global::SwineTracker.Properties.Resources.cargarBase;
            this.btnCargarDatos.Location = new System.Drawing.Point(34, 444);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(195, 65);
            this.btnCargarDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCargarDatos.TabIndex = 39;
            this.btnCargarDatos.TabStop = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            this.btnCargarDatos.MouseLeave += new System.EventHandler(this.btnCargarDatos_MouseLeave);
            this.btnCargarDatos.MouseHover += new System.EventHandler(this.btnCargarDatos_MouseHover);
            // 
            // btnBajas
            // 
            this.btnBajas.BackColor = System.Drawing.Color.White;
            this.btnBajas.Location = new System.Drawing.Point(897, 286);
            this.btnBajas.Name = "btnBajas";
            this.btnBajas.Size = new System.Drawing.Size(195, 120);
            this.btnBajas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBajas.TabIndex = 38;
            this.btnBajas.TabStop = false;
            this.btnBajas.Click += new System.EventHandler(this.btnBajas_Click);
            this.btnBajas.MouseLeave += new System.EventHandler(this.btnBajas_MouseLeave);
            this.btnBajas.MouseHover += new System.EventHandler(this.btnBajas_MouseHover);
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.Image = global::SwineTracker.Properties.Resources.notificaciones;
            this.btnNotificaciones.Location = new System.Drawing.Point(668, 286);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Size = new System.Drawing.Size(195, 120);
            this.btnNotificaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNotificaciones.TabIndex = 37;
            this.btnNotificaciones.TabStop = false;
            this.btnNotificaciones.Click += new System.EventHandler(this.btnNotificaciones_Click);
            this.btnNotificaciones.MouseLeave += new System.EventHandler(this.btnNotificaciones_MouseLeave);
            this.btnNotificaciones.MouseHover += new System.EventHandler(this.btnNotificaciones_MouseHover);
            // 
            // btnDestete
            // 
            this.btnDestete.Image = global::SwineTracker.Properties.Resources.destete;
            this.btnDestete.Location = new System.Drawing.Point(455, 286);
            this.btnDestete.Name = "btnDestete";
            this.btnDestete.Size = new System.Drawing.Size(195, 120);
            this.btnDestete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDestete.TabIndex = 36;
            this.btnDestete.TabStop = false;
            this.btnDestete.Click += new System.EventHandler(this.btnDestete_Click);
            this.btnDestete.MouseLeave += new System.EventHandler(this.btnDestete_MouseLeave);
            this.btnDestete.MouseHover += new System.EventHandler(this.btnDestete_MouseHover);
            // 
            // btnProyeccion
            // 
            this.btnProyeccion.Image = global::SwineTracker.Properties.Resources.proyeccionPartos;
            this.btnProyeccion.Location = new System.Drawing.Point(243, 286);
            this.btnProyeccion.Name = "btnProyeccion";
            this.btnProyeccion.Size = new System.Drawing.Size(195, 120);
            this.btnProyeccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProyeccion.TabIndex = 35;
            this.btnProyeccion.TabStop = false;
            this.btnProyeccion.Click += new System.EventHandler(this.btnProyeccion_Click);
            this.btnProyeccion.MouseLeave += new System.EventHandler(this.btnProyeccion_MouseLeave);
            this.btnProyeccion.MouseHover += new System.EventHandler(this.btnProyeccion_MouseHover);
            // 
            // btnFechaConfirmacion
            // 
            this.btnFechaConfirmacion.Image = global::SwineTracker.Properties.Resources.fichasConfirmacion;
            this.btnFechaConfirmacion.Location = new System.Drawing.Point(34, 286);
            this.btnFechaConfirmacion.Name = "btnFechaConfirmacion";
            this.btnFechaConfirmacion.Size = new System.Drawing.Size(195, 120);
            this.btnFechaConfirmacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechaConfirmacion.TabIndex = 34;
            this.btnFechaConfirmacion.TabStop = false;
            this.btnFechaConfirmacion.Click += new System.EventHandler(this.btnFechaConfirmacion_Click);
            this.btnFechaConfirmacion.MouseLeave += new System.EventHandler(this.btnFechaConfirmacion_MouseLeave);
            this.btnFechaConfirmacion.MouseHover += new System.EventHandler(this.btnFechaConfirmacion_MouseHover);
            // 
            // btnComparativaF
            // 
            this.btnComparativaF.Image = global::SwineTracker.Properties.Resources.comparativaFechas;
            this.btnComparativaF.Location = new System.Drawing.Point(897, 136);
            this.btnComparativaF.Name = "btnComparativaF";
            this.btnComparativaF.Size = new System.Drawing.Size(195, 120);
            this.btnComparativaF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnComparativaF.TabIndex = 33;
            this.btnComparativaF.TabStop = false;
            this.btnComparativaF.Click += new System.EventHandler(this.btnComparativaF_Click);
            this.btnComparativaF.MouseLeave += new System.EventHandler(this.btnComparativaF_MouseLeave);
            this.btnComparativaF.MouseHover += new System.EventHandler(this.btnComparativaF_MouseHover);
            // 
            // btnComparativaH
            // 
            this.btnComparativaH.Image = global::SwineTracker.Properties.Resources.comparativaHembras;
            this.btnComparativaH.Location = new System.Drawing.Point(668, 136);
            this.btnComparativaH.Name = "btnComparativaH";
            this.btnComparativaH.Size = new System.Drawing.Size(195, 120);
            this.btnComparativaH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnComparativaH.TabIndex = 32;
            this.btnComparativaH.TabStop = false;
            this.btnComparativaH.Click += new System.EventHandler(this.btnComparativaH_Click);
            this.btnComparativaH.MouseLeave += new System.EventHandler(this.btnComparativaH_MouseLeave);
            this.btnComparativaH.MouseHover += new System.EventHandler(this.btnComparativaH_MouseHover);
            // 
            // btnFichas
            // 
            this.btnFichas.Image = global::SwineTracker.Properties.Resources.fichaHembras;
            this.btnFichas.Location = new System.Drawing.Point(455, 136);
            this.btnFichas.Name = "btnFichas";
            this.btnFichas.Size = new System.Drawing.Size(195, 120);
            this.btnFichas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFichas.TabIndex = 31;
            this.btnFichas.TabStop = false;
            this.btnFichas.Click += new System.EventHandler(this.btnFichas_Click);
            this.btnFichas.MouseLeave += new System.EventHandler(this.btnFichas_MouseLeave);
            this.btnFichas.MouseHover += new System.EventHandler(this.btnFichas_MouseHover);
            // 
            // btnInseminacion
            // 
            this.btnInseminacion.BackColor = System.Drawing.Color.White;
            this.btnInseminacion.Location = new System.Drawing.Point(243, 136);
            this.btnInseminacion.Name = "btnInseminacion";
            this.btnInseminacion.Size = new System.Drawing.Size(195, 120);
            this.btnInseminacion.TabIndex = 30;
            this.btnInseminacion.TabStop = false;
            this.btnInseminacion.Click += new System.EventHandler(this.btnInseminacion_Click);
            this.btnInseminacion.MouseLeave += new System.EventHandler(this.btnInseminacion_MouseLeave);
            this.btnInseminacion.MouseHover += new System.EventHandler(this.btnInseminacion_MouseHover);
            // 
            // BtnRemplazos
            // 
            this.BtnRemplazos.BackColor = System.Drawing.Color.White;
            this.BtnRemplazos.Location = new System.Drawing.Point(34, 136);
            this.BtnRemplazos.Name = "BtnRemplazos";
            this.BtnRemplazos.Size = new System.Drawing.Size(195, 120);
            this.BtnRemplazos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnRemplazos.TabIndex = 29;
            this.BtnRemplazos.TabStop = false;
            this.BtnRemplazos.Click += new System.EventHandler(this.BtnRemplazos_Click);
            this.BtnRemplazos.MouseLeave += new System.EventHandler(this.BtnRemplazos_MouseLeave);
            this.BtnRemplazos.MouseHover += new System.EventHandler(this.BtnRemplazos_MouseHover);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1132, 588);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportarDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCargarDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDestete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProyeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechaConfirmacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComparativaF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnComparativaH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFichas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInseminacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRemplazos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnSesion;
        private System.Windows.Forms.PictureBox btnExportarDatos;
        private System.Windows.Forms.PictureBox btnCargarDatos;
        private System.Windows.Forms.PictureBox btnBajas;
        private System.Windows.Forms.PictureBox btnNotificaciones;
        private System.Windows.Forms.PictureBox btnDestete;
        private System.Windows.Forms.PictureBox btnProyeccion;
        private System.Windows.Forms.PictureBox btnFechaConfirmacion;
        private System.Windows.Forms.PictureBox btnComparativaF;
        private System.Windows.Forms.PictureBox btnComparativaH;
        private System.Windows.Forms.PictureBox btnFichas;
        private System.Windows.Forms.PictureBox btnInseminacion;
        private System.Windows.Forms.PictureBox BtnRemplazos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

