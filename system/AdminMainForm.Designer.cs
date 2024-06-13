namespace system
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.username_name = new System.Windows.Forms.Label();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.center_panel = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.logout_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Customers_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Products_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Cashier_btn = new Guna.UI2.WinForms.Guna2Button();
            this.home_btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.guna2ControlBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 60);
            this.panel1.TabIndex = 0;
            // 
            // close
            // 
            this.close.CheckedState.Parent = this.close;
            this.close.CustomImages.Parent = this.close;
            this.close.FillColor = System.Drawing.SystemColors.ControlDark;
            this.close.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.HoverState.Parent = this.close;
            this.close.Location = new System.Drawing.Point(883, 14);
            this.close.Name = "close";
            this.close.ShadowDecoration.Parent = this.close;
            this.close.Size = new System.Drawing.Size(45, 29);
            this.close.TabIndex = 7;
            this.close.Text = "X";
            this.close.TextOffset = new System.Drawing.Point(0, 1);
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // guna2ControlBox4
            // 
            this.guna2ControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox4.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox4.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox4.FillColor = System.Drawing.SystemColors.ControlDark;
            this.guna2ControlBox4.HoverState.Parent = this.guna2ControlBox4;
            this.guna2ControlBox4.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox4.Location = new System.Drawing.Point(820, 14);
            this.guna2ControlBox4.Name = "guna2ControlBox4";
            this.guna2ControlBox4.ShadowDecoration.Parent = this.guna2ControlBox4;
            this.guna2ControlBox4.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox4.TabIndex = 6;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.guna2Panel1.Controls.Add(this.logout_btn);
            this.guna2Panel1.Controls.Add(this.Customers_btn);
            this.guna2Panel1.Controls.Add(this.Products_btn);
            this.guna2Panel1.Controls.Add(this.Cashier_btn);
            this.guna2Panel1.Controls.Add(this.home_btn);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 60);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(196, 615);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.username_name);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(196, 58);
            this.guna2Panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // username_name
            // 
            this.username_name.AutoSize = true;
            this.username_name.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.username_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.username_name.Location = new System.Drawing.Point(102, 19);
            this.username_name.Name = "username_name";
            this.username_name.Size = new System.Drawing.Size(48, 20);
            this.username_name.TabIndex = 3;
            this.username_name.Text = "name";
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuLabel1.Location = new System.Drawing.Point(66, 8);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(73, 45);
            this.bunifuLabel1.TabIndex = 3;
            this.bunifuLabel1.Text = "RMS";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // center_panel
            // 
            this.center_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.center_panel.Location = new System.Drawing.Point(196, 60);
            this.center_panel.Name = "center_panel";
            this.center_panel.Size = new System.Drawing.Size(744, 615);
            this.center_panel.TabIndex = 5;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::system.Properties.Resources.code_optimisation_2721684;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 9);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(48, 45);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // logout_btn
            // 
            this.logout_btn.CheckedState.Parent = this.logout_btn;
            this.logout_btn.CustomImages.Parent = this.logout_btn;
            this.logout_btn.FillColor = System.Drawing.Color.Transparent;
            this.logout_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logout_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.logout_btn.HoverState.Parent = this.logout_btn;
            this.logout_btn.Image = global::system.Properties.Resources.icons8_выход_30__1_;
            this.logout_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logout_btn.Location = new System.Drawing.Point(22, 558);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.ShadowDecoration.Parent = this.logout_btn;
            this.logout_btn.Size = new System.Drawing.Size(174, 45);
            this.logout_btn.TabIndex = 6;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // Customers_btn
            // 
            this.Customers_btn.CheckedState.Parent = this.Customers_btn;
            this.Customers_btn.CustomImages.Parent = this.Customers_btn;
            this.Customers_btn.FillColor = System.Drawing.Color.Transparent;
            this.Customers_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Customers_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.Customers_btn.HoverState.Parent = this.Customers_btn;
            this.Customers_btn.Image = global::system.Properties.Resources.icons8_конференция_фон_выбранные_48;
            this.Customers_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Customers_btn.Location = new System.Drawing.Point(22, 224);
            this.Customers_btn.Name = "Customers_btn";
            this.Customers_btn.ShadowDecoration.Parent = this.Customers_btn;
            this.Customers_btn.Size = new System.Drawing.Size(174, 45);
            this.Customers_btn.TabIndex = 5;
            this.Customers_btn.Text = "Customers";
            this.Customers_btn.Click += new System.EventHandler(this.Customers_btn_Click);
            // 
            // Products_btn
            // 
            this.Products_btn.CheckedState.Parent = this.Products_btn;
            this.Products_btn.CustomImages.Parent = this.Products_btn;
            this.Products_btn.FillColor = System.Drawing.Color.Transparent;
            this.Products_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Products_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.Products_btn.HoverState.Parent = this.Products_btn;
            this.Products_btn.Image = global::system.Properties.Resources.icons8_плюс_60;
            this.Products_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Products_btn.Location = new System.Drawing.Point(22, 173);
            this.Products_btn.Name = "Products_btn";
            this.Products_btn.ShadowDecoration.Parent = this.Products_btn;
            this.Products_btn.Size = new System.Drawing.Size(174, 45);
            this.Products_btn.TabIndex = 4;
            this.Products_btn.Text = "Products";
            this.Products_btn.Click += new System.EventHandler(this.Products_btn_Click);
            // 
            // Cashier_btn
            // 
            this.Cashier_btn.CheckedState.Parent = this.Cashier_btn;
            this.Cashier_btn.CustomImages.Parent = this.Cashier_btn;
            this.Cashier_btn.FillColor = System.Drawing.Color.Transparent;
            this.Cashier_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cashier_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.Cashier_btn.HoverState.Parent = this.Cashier_btn;
            this.Cashier_btn.Image = global::system.Properties.Resources.icons8_плюс_60;
            this.Cashier_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Cashier_btn.Location = new System.Drawing.Point(22, 122);
            this.Cashier_btn.Name = "Cashier_btn";
            this.Cashier_btn.ShadowDecoration.Parent = this.Cashier_btn;
            this.Cashier_btn.Size = new System.Drawing.Size(174, 45);
            this.Cashier_btn.TabIndex = 3;
            this.Cashier_btn.Text = "Cashier";
            this.Cashier_btn.Click += new System.EventHandler(this.Cashier_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.CheckedState.Parent = this.home_btn;
            this.home_btn.CustomImages.Parent = this.home_btn;
            this.home_btn.FillColor = System.Drawing.Color.Transparent;
            this.home_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.home_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.home_btn.HoverState.Parent = this.home_btn;
            this.home_btn.Image = global::system.Properties.Resources.icons8_главная_48;
            this.home_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.home_btn.Location = new System.Drawing.Point(22, 71);
            this.home_btn.Name = "home_btn";
            this.home_btn.ShadowDecoration.Parent = this.home_btn;
            this.home_btn.Size = new System.Drawing.Size(174, 45);
            this.home_btn.TabIndex = 2;
            this.home_btn.Text = "Home";
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(940, 675);
            this.Controls.Add(this.center_panel);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username_name;
        private Guna.UI2.WinForms.Guna2Button home_btn;
        private Guna.UI2.WinForms.Guna2Button Cashier_btn;
        private Guna.UI2.WinForms.Guna2Button Customers_btn;
        private Guna.UI2.WinForms.Guna2Button Products_btn;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button logout_btn;
        private System.Windows.Forms.Panel center_panel;
        private Guna.UI2.WinForms.Guna2Button close;
    }
}