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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.LoginBtn = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PassordTxt = new MetroFramework.Controls.MetroTextBox();
            this.UsernameTxt = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(146, 137);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(130, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Iniciar Sesión";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Image = global::SwineTracker.Properties.Resources.minimizar;
            this.btnMin.Location = new System.Drawing.Point(713, 12);
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
            this.btnMax.Location = new System.Drawing.Point(745, 11);
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
            this.btnClose.Location = new System.Drawing.Point(777, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.White;
            this.LoginBtn.Image = global::SwineTracker.Properties.Resources.botonLogin;
            this.LoginBtn.Location = new System.Drawing.Point(126, 298);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(170, 50);
            this.LoginBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.TabStop = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            this.LoginBtn.MouseLeave += new System.EventHandler(this.LoginBtn_MouseLeave);
            this.LoginBtn.MouseHover += new System.EventHandler(this.LoginBtn_MouseHover);
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.Image = global::SwineTracker.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(440, 203);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(345, 126);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // PassordTxt
            // 
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
            this.PassordTxt.Location = new System.Drawing.Point(117, 232);
            this.PassordTxt.MaxLength = 32767;
            this.PassordTxt.Name = "PassordTxt";
            this.PassordTxt.PasswordChar = '.';
            this.PassordTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassordTxt.SelectedText = "";
            this.PassordTxt.SelectionLength = 0;
            this.PassordTxt.SelectionStart = 0;
            this.PassordTxt.ShortcutsEnabled = true;
            this.PassordTxt.Size = new System.Drawing.Size(190, 25);
            this.PassordTxt.TabIndex = 2;
            this.PassordTxt.UseSelectable = true;
            this.PassordTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassordTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UsernameTxt
            // 
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
            this.UsernameTxt.Location = new System.Drawing.Point(117, 180);
            this.UsernameTxt.MaxLength = 32767;
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.PasswordChar = '\0';
            this.UsernameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameTxt.SelectedText = "";
            this.UsernameTxt.SelectionLength = 0;
            this.UsernameTxt.SelectionStart = 0;
            this.UsernameTxt.ShortcutsEnabled = true;
            this.UsernameTxt.Size = new System.Drawing.Size(190, 25);
            this.UsernameTxt.TabIndex = 1;
            this.UsernameTxt.Text = "Admin";
            this.UsernameTxt.UseSelectable = true;
            this.UsernameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SwineTracker.Properties.Resources.TwinBackground;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 558);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(115F, 115F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(814, 558);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.PassordTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResizeEnd += new System.EventHandler(this.Login_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox UsernameTxt;
        private MetroFramework.Controls.MetroTextBox PassordTxt;
        private System.Windows.Forms.PictureBox LoginBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}