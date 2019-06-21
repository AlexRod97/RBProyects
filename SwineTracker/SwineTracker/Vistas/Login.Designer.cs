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
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.UsernameTxt = new MetroFramework.Controls.MetroTextBox();
            this.PassordTxt = new MetroFramework.Controls.MetroTextBox();
            this.LoginBtn = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CredentialsPanel = new System.Windows.Forms.Panel();
            this.Background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBtn)).BeginInit();
            this.CredentialsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Image = global::SwineTracker.Properties.Resources.minimizar;
            this.btnMin.Location = new System.Drawing.Point(781, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMin.TabIndex = 7;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Image = global::SwineTracker.Properties.Resources.maximizar;
            this.btnMax.Location = new System.Drawing.Point(813, 11);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 25);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMax.TabIndex = 6;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
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
            // UsernameTxt
            // 
            this.UsernameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.UsernameTxt.CustomButton.Image = null;
            this.UsernameTxt.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.UsernameTxt.CustomButton.Name = "";
            this.UsernameTxt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.UsernameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsernameTxt.CustomButton.TabIndex = 1;
            this.UsernameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsernameTxt.CustomButton.UseSelectable = true;
            this.UsernameTxt.CustomButton.Visible = false;
            this.UsernameTxt.DisplayIcon = true;
            this.UsernameTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.UsernameTxt.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.UsernameTxt.Icon = global::SwineTracker.Properties.Resources.user;
            this.UsernameTxt.Lines = new string[] {
        "Admin"};
            this.UsernameTxt.Location = new System.Drawing.Point(22, 110);
            this.UsernameTxt.MaxLength = 32767;
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.PasswordChar = '\0';
            this.UsernameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameTxt.SelectedText = "";
            this.UsernameTxt.SelectionLength = 0;
            this.UsernameTxt.SelectionStart = 0;
            this.UsernameTxt.ShortcutsEnabled = true;
            this.UsernameTxt.Size = new System.Drawing.Size(240, 25);
            this.UsernameTxt.TabIndex = 0;
            this.UsernameTxt.Text = "Admin";
            this.UsernameTxt.UseSelectable = true;
            this.UsernameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PassordTxt
            // 
            this.PassordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.PassordTxt.CustomButton.Image = null;
            this.PassordTxt.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.PassordTxt.CustomButton.Name = "";
            this.PassordTxt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.PassordTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassordTxt.CustomButton.TabIndex = 1;
            this.PassordTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassordTxt.CustomButton.UseSelectable = true;
            this.PassordTxt.CustomButton.Visible = false;
            this.PassordTxt.DisplayIcon = true;
            this.PassordTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PassordTxt.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.PassordTxt.Icon = global::SwineTracker.Properties.Resources.password1;
            this.PassordTxt.Lines = new string[0];
            this.PassordTxt.Location = new System.Drawing.Point(22, 177);
            this.PassordTxt.MaxLength = 32767;
            this.PassordTxt.Name = "PassordTxt";
            this.PassordTxt.PasswordChar = '.';
            this.PassordTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassordTxt.SelectedText = "";
            this.PassordTxt.SelectionLength = 0;
            this.PassordTxt.SelectionStart = 0;
            this.PassordTxt.ShortcutsEnabled = true;
            this.PassordTxt.Size = new System.Drawing.Size(240, 25);
            this.PassordTxt.TabIndex = 1;
            this.PassordTxt.UseSelectable = true;
            this.PassordTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassordTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginBtn.BackColor = System.Drawing.Color.White;
            this.LoginBtn.Image = global::SwineTracker.Properties.Resources.botonLogin;
            this.LoginBtn.Location = new System.Drawing.Point(22, 257);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(180, 50);
            this.LoginBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginBtn.TabIndex = 7;
            this.LoginBtn.TabStop = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            this.LoginBtn.MouseLeave += new System.EventHandler(this.LoginBtn_MouseLeave);
            this.LoginBtn.MouseHover += new System.EventHandler(this.LoginBtn_MouseHover);
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
            this.CredentialsPanel.Controls.Add(this.metroLabel1);
            this.CredentialsPanel.Controls.Add(this.LoginBtn);
            this.CredentialsPanel.Controls.Add(this.PassordTxt);
            this.CredentialsPanel.Controls.Add(this.UsernameTxt);
            this.CredentialsPanel.Location = new System.Drawing.Point(65, 135);
            this.CredentialsPanel.Name = "CredentialsPanel";
            this.CredentialsPanel.Size = new System.Drawing.Size(280, 365);
            this.CredentialsPanel.TabIndex = 9;
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
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(882, 605);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Resize += new System.EventHandler(this.Login_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBtn)).EndInit();
            this.CredentialsPanel.ResumeLayout(false);
            this.CredentialsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox Logo;
        private MetroFramework.Controls.MetroTextBox UsernameTxt;
        private MetroFramework.Controls.MetroTextBox PassordTxt;
        private System.Windows.Forms.PictureBox LoginBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel CredentialsPanel;
        private System.Windows.Forms.PictureBox Background;
    }
}