namespace system
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.close_btn = new System.Windows.Forms.Label();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.register_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.register_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.register_cPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.register_showPass = new System.Windows.Forms.CheckBox();
            this.register_loginLink = new System.Windows.Forms.LinkLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.register_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuLabel3);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(81)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.BlueViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(81)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Indigo;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(228, 395);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_btn.Location = new System.Drawing.Point(542, 7);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(15, 13);
            this.close_btn.TabIndex = 18;
            this.close_btn.Text = "X";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.BlueViolet;
            this.bunifuLabel2.Location = new System.Drawing.Point(335, 25);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(121, 45);
            this.bunifuLabel2.TabIndex = 19;
            this.bunifuLabel2.Text = "Sign Up";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(36, 76);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(155, 45);
            this.bunifuLabel3.TabIndex = 20;
            this.bunifuLabel3.Text = "Welcome!";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // register_username
            // 
            this.register_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.register_username.DefaultText = "";
            this.register_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.register_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.register_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_username.DisabledState.Parent = this.register_username;
            this.register_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_username.FocusedState.Parent = this.register_username;
            this.register_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_username.HoverState.Parent = this.register_username;
            this.register_username.IconLeft = global::system.Properties.Resources.user_1144760;
            this.register_username.Location = new System.Drawing.Point(266, 101);
            this.register_username.Name = "register_username";
            this.register_username.PasswordChar = '\0';
            this.register_username.PlaceholderText = "Enter your username";
            this.register_username.SelectedText = "";
            this.register_username.ShadowDecoration.Parent = this.register_username;
            this.register_username.Size = new System.Drawing.Size(260, 40);
            this.register_username.TabIndex = 20;
            // 
            // register_password
            // 
            this.register_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.register_password.DefaultText = "";
            this.register_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.register_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.register_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_password.DisabledState.Parent = this.register_password;
            this.register_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_password.FocusedState.Parent = this.register_password;
            this.register_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_password.HoverState.Parent = this.register_password;
            this.register_password.IconLeft = global::system.Properties.Resources.icons8_lock_50;
            this.register_password.Location = new System.Drawing.Point(266, 153);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '\0';
            this.register_password.PlaceholderText = "Enter your password";
            this.register_password.SelectedText = "";
            this.register_password.ShadowDecoration.Parent = this.register_password;
            this.register_password.Size = new System.Drawing.Size(260, 40);
            this.register_password.TabIndex = 21;
            this.register_password.UseSystemPasswordChar = true;
            // 
            // register_cPassword
            // 
            this.register_cPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.register_cPassword.DefaultText = "";
            this.register_cPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.register_cPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.register_cPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_cPassword.DisabledState.Parent = this.register_cPassword;
            this.register_cPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_cPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_cPassword.FocusedState.Parent = this.register_cPassword;
            this.register_cPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_cPassword.HoverState.Parent = this.register_cPassword;
            this.register_cPassword.IconLeft = global::system.Properties.Resources.icons8_lock_50;
            this.register_cPassword.Location = new System.Drawing.Point(266, 204);
            this.register_cPassword.Name = "register_cPassword";
            this.register_cPassword.PasswordChar = '\0';
            this.register_cPassword.PlaceholderText = "Repeat your password";
            this.register_cPassword.SelectedText = "";
            this.register_cPassword.ShadowDecoration.Parent = this.register_cPassword;
            this.register_cPassword.Size = new System.Drawing.Size(260, 40);
            this.register_cPassword.TabIndex = 22;
            this.register_cPassword.UseSystemPasswordChar = true;
            // 
            // register_showPass
            // 
            this.register_showPass.AutoSize = true;
            this.register_showPass.Location = new System.Drawing.Point(266, 253);
            this.register_showPass.Name = "register_showPass";
            this.register_showPass.Size = new System.Drawing.Size(102, 17);
            this.register_showPass.TabIndex = 23;
            this.register_showPass.Text = "Show Password";
            this.register_showPass.UseVisualStyleBackColor = true;
            this.register_showPass.CheckedChanged += new System.EventHandler(this.register_showPass_CheckedChanged);
            // 
            // register_loginLink
            // 
            this.register_loginLink.AutoSize = true;
            this.register_loginLink.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_loginLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.register_loginLink.LinkColor = System.Drawing.Color.BlueViolet;
            this.register_loginLink.Location = new System.Drawing.Point(444, 367);
            this.register_loginLink.Name = "register_loginLink";
            this.register_loginLink.Size = new System.Drawing.Size(41, 13);
            this.register_loginLink.TabIndex = 25;
            this.register_loginLink.TabStop = true;
            this.register_loginLink.Text = "Sign In";
            this.register_loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_loginLink_LinkClicked);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuLabel4.Location = new System.Drawing.Point(308, 366);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(135, 15);
            this.bunifuLabel4.TabIndex = 24;
            this.bunifuLabel4.Text = "Already have an account?";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // register_btn
            // 
            this.register_btn.AutoRoundedCorners = true;
            this.register_btn.BorderRadius = 21;
            this.register_btn.CheckedState.Parent = this.register_btn;
            this.register_btn.CustomImages.Parent = this.register_btn;
            this.register_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(57)))), ((int)(((byte)(100)))));
            this.register_btn.FillColor2 = System.Drawing.Color.DarkSlateBlue;
            this.register_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.HoverState.Parent = this.register_btn;
            this.register_btn.Location = new System.Drawing.Point(307, 290);
            this.register_btn.Name = "register_btn";
            this.register_btn.ShadowDecoration.Parent = this.register_btn;
            this.register_btn.Size = new System.Drawing.Size(180, 45);
            this.register_btn.TabIndex = 26;
            this.register_btn.Text = "Register";
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 395);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.register_loginLink);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.register_showPass);
            this.Controls.Add(this.register_cPassword);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label close_btn;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Guna.UI2.WinForms.Guna2TextBox register_username;
        private Guna.UI2.WinForms.Guna2TextBox register_password;
        private Guna.UI2.WinForms.Guna2TextBox register_cPassword;
        private System.Windows.Forms.CheckBox register_showPass;
        private System.Windows.Forms.LinkLabel register_loginLink;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Guna.UI2.WinForms.Guna2GradientButton register_btn;
    }
}