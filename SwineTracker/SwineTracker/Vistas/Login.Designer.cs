namespace SwineTracker.Vistas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CredentialsPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.PictureBox();
            this.bgUser = new System.Windows.Forms.PictureBox();
            this.bgPassword = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CredentialsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(22, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Iniciar Sesión";
            // 
            // CredentialsPanel
            // 
            this.CredentialsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CredentialsPanel.BackColor = System.Drawing.Color.White;
            this.CredentialsPanel.Controls.Add(this.panel1);
            this.CredentialsPanel.Controls.Add(this.pictureBox2);
            this.CredentialsPanel.Controls.Add(this.pictureBox1);
            this.CredentialsPanel.Controls.Add(this.txtPassword);
            this.CredentialsPanel.Controls.Add(this.txtUsername);
            this.CredentialsPanel.Controls.Add(this.metroLabel1);
            this.CredentialsPanel.Controls.Add(this.LoginBtn);
            this.CredentialsPanel.Controls.Add(this.bgUser);
            this.CredentialsPanel.Controls.Add(this.bgPassword);
            this.CredentialsPanel.Location = new System.Drawing.Point(65, 135);
            this.CredentialsPanel.Name = "CredentialsPanel";
            this.CredentialsPanel.Size = new System.Drawing.Size(280, 365);
            this.CredentialsPanel.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SwineTracker.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(45, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SwineTracker.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(45, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(71, 184);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 26);
            this.txtPassword.TabIndex = 12;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(71, 114);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(165, 26);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.Text = "Admin";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginBtn.BackColor = System.Drawing.Color.White;
            this.LoginBtn.Image = global::SwineTracker.Properties.Resources.botonLogin;
            this.LoginBtn.Location = new System.Drawing.Point(27, 288);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(180, 50);
            this.LoginBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginBtn.TabIndex = 7;
            this.LoginBtn.TabStop = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            this.LoginBtn.MouseLeave += new System.EventHandler(this.LoginBtn_MouseLeave);
            this.LoginBtn.MouseHover += new System.EventHandler(this.LoginBtn_MouseHover);
            // 
            // bgUser
            // 
            this.bgUser.Image = global::SwineTracker.Properties.Resources.inputlarge;
            this.bgUser.Location = new System.Drawing.Point(22, 98);
            this.bgUser.Name = "bgUser";
            this.bgUser.Size = new System.Drawing.Size(231, 50);
            this.bgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bgUser.TabIndex = 9;
            this.bgUser.TabStop = false;
            // 
            // bgPassword
            // 
            this.bgPassword.Image = global::SwineTracker.Properties.Resources.inputlarge;
            this.bgPassword.Location = new System.Drawing.Point(22, 171);
            this.bgPassword.Name = "bgPassword";
            this.bgPassword.Size = new System.Drawing.Size(231, 50);
            this.bgPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bgPassword.TabIndex = 10;
            this.bgPassword.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Image = global::SwineTracker.Properties.Resources.minimizar;
            this.btnMin.Location = new System.Drawing.Point(814, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMin.TabIndex = 7;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            this.btnMin.MouseHover += new System.EventHandler(this.btnMin_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::SwineTracker.Properties.Resources.cerrar;
            this.btnClose.Location = new System.Drawing.Point(845, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.Image = global::SwineTracker.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(441, 211);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(429, 190);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // Background
            // 
            this.Background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Background.Image = global::SwineTracker.Properties.Resources.TwinBackground;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(882, 650);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background.TabIndex = 8;
            this.Background.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 42);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Usuario o contraseña incorrecta";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SwineTracker.Properties.Resources.warning;
            this.pictureBox3.Location = new System.Drawing.Point(14, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // Login
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(882, 605);
            this.Controls.Add(this.CredentialsPanel);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(882, 605);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Resize += new System.EventHandler(this.Login_Resize);
            this.CredentialsPanel.ResumeLayout(false);
            this.CredentialsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox LoginBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel CredentialsPanel;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox bgUser;
        private System.Windows.Forms.PictureBox bgPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}