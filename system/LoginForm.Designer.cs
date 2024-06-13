namespace system
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.login_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.close_btn = new System.Windows.Forms.Label();
            this.login_showPass = new System.Windows.Forms.CheckBox();
            this.login_registerLink = new System.Windows.Forms.LinkLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.login_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.BlueViolet;
            this.bunifuLabel1.Location = new System.Drawing.Point(334, 25);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(107, 45);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Sign In";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // login_password
            // 
            this.login_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_password.DefaultText = "";
            this.login_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_password.DisabledState.Parent = this.login_password;
            this.login_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_password.FocusedState.Parent = this.login_password;
            this.login_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_password.HoverState.Parent = this.login_password;
            this.login_password.IconLeft = global::system.Properties.Resources.icons8_lock_50;
            this.login_password.Location = new System.Drawing.Point(263, 147);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '\0';
            this.login_password.PlaceholderText = "Enter your password";
            this.login_password.SelectedText = "";
            this.login_password.ShadowDecoration.Parent = this.login_password;
            this.login_password.Size = new System.Drawing.Size(260, 40);
            this.login_password.TabIndex = 3;
            this.login_password.UseSystemPasswordChar = true;
            // 
            // login_username
            // 
            this.login_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_username.DefaultText = "";
            this.login_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_username.DisabledState.Parent = this.login_username;
            this.login_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_username.FocusedState.Parent = this.login_username;
            this.login_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_username.HoverState.Parent = this.login_username;
            this.login_username.IconLeft = global::system.Properties.Resources.user_1144760;
            this.login_username.Location = new System.Drawing.Point(263, 95);
            this.login_username.Name = "login_username";
            this.login_username.PasswordChar = '\0';
            this.login_username.PlaceholderText = "Enter your username";
            this.login_username.SelectedText = "";
            this.login_username.ShadowDecoration.Parent = this.login_username;
            this.login_username.Size = new System.Drawing.Size(260, 40);
            this.login_username.TabIndex = 2;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuLabel2);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(81)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.BlueViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(81)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Indigo;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(228, 339);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(36, 76);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(155, 45);
            this.bunifuLabel2.TabIndex = 0;
            this.bunifuLabel2.Text = "Welcome!";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_btn.Location = new System.Drawing.Point(537, 7);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(15, 13);
            this.close_btn.TabIndex = 17;
            this.close_btn.Text = "X";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // login_showPass
            // 
            this.login_showPass.AutoSize = true;
            this.login_showPass.Location = new System.Drawing.Point(263, 200);
            this.login_showPass.Name = "login_showPass";
            this.login_showPass.Size = new System.Drawing.Size(102, 17);
            this.login_showPass.TabIndex = 18;
            this.login_showPass.Text = "Show Password";
            this.login_showPass.UseVisualStyleBackColor = true;
            this.login_showPass.CheckedChanged += new System.EventHandler(this.login_showPass_CheckedChanged);
            // 
            // login_registerLink
            // 
            this.login_registerLink.AutoSize = true;
            this.login_registerLink.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_registerLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.login_registerLink.LinkColor = System.Drawing.Color.BlueViolet;
            this.login_registerLink.Location = new System.Drawing.Point(432, 313);
            this.login_registerLink.Name = "login_registerLink";
            this.login_registerLink.Size = new System.Drawing.Size(47, 13);
            this.login_registerLink.TabIndex = 20;
            this.login_registerLink.TabStop = true;
            this.login_registerLink.Text = "Sign Up";
            this.login_registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_registerLink_LinkClicked);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuLabel4.Location = new System.Drawing.Point(307, 313);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(121, 15);
            this.bunifuLabel4.TabIndex = 19;
            this.bunifuLabel4.Text = "Dont have an account?";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // login_btn
            // 
            this.login_btn.AutoRoundedCorners = true;
            this.login_btn.BorderRadius = 21;
            this.login_btn.CheckedState.Parent = this.login_btn;
            this.login_btn.CustomImages.Parent = this.login_btn;
            this.login_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(57)))), ((int)(((byte)(100)))));
            this.login_btn.FillColor2 = System.Drawing.Color.DarkSlateBlue;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.HoverState.Parent = this.login_btn;
            this.login_btn.Location = new System.Drawing.Point(302, 240);
            this.login_btn.Name = "login_btn";
            this.login_btn.ShadowDecoration.Parent = this.login_btn;
            this.login_btn.Size = new System.Drawing.Size(180, 45);
            this.login_btn.TabIndex = 21;
            this.login_btn.Text = "Login";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 339);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_registerLink);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.login_showPass);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Guna.UI2.WinForms.Guna2TextBox login_username;
        private Guna.UI2.WinForms.Guna2TextBox login_password;
        private System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.CheckBox login_showPass;
        private System.Windows.Forms.LinkLabel login_registerLink;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Guna.UI2.WinForms.Guna2GradientButton login_btn;
    }
}