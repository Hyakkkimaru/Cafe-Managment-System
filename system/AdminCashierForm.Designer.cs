namespace system
{
    partial class AdminCashierForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminAddUsers_importBtn = new Guna.UI2.WinForms.Guna2Button();
            this.adminAddUsers_clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.adminAddUsers_deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.adminAddUsers_updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.adminAddUsers_addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.adminAddUsers_status = new System.Windows.Forms.ComboBox();
            this.adminAddUsers_role = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminAddUsers_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminAddUsers_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminAddUsers_imageView = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAddUsers_imageView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(274, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 585);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(10, 55);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(435, 518);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data of Users";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.adminAddUsers_importBtn);
            this.panel1.Controls.Add(this.adminAddUsers_imageView);
            this.panel1.Controls.Add(this.adminAddUsers_clearBtn);
            this.panel1.Controls.Add(this.adminAddUsers_deleteBtn);
            this.panel1.Controls.Add(this.adminAddUsers_updateBtn);
            this.panel1.Controls.Add(this.adminAddUsers_addBtn);
            this.panel1.Controls.Add(this.adminAddUsers_status);
            this.panel1.Controls.Add(this.adminAddUsers_role);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.adminAddUsers_password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.adminAddUsers_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 585);
            this.panel1.TabIndex = 2;
            // 
            // adminAddUsers_importBtn
            // 
            this.adminAddUsers_importBtn.CheckedState.Parent = this.adminAddUsers_importBtn;
            this.adminAddUsers_importBtn.CustomImages.Parent = this.adminAddUsers_importBtn;
            this.adminAddUsers_importBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.adminAddUsers_importBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminAddUsers_importBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUsers_importBtn.HoverState.Parent = this.adminAddUsers_importBtn;
            this.adminAddUsers_importBtn.Location = new System.Drawing.Point(71, 126);
            this.adminAddUsers_importBtn.Name = "adminAddUsers_importBtn";
            this.adminAddUsers_importBtn.ShadowDecoration.Parent = this.adminAddUsers_importBtn;
            this.adminAddUsers_importBtn.Size = new System.Drawing.Size(103, 33);
            this.adminAddUsers_importBtn.TabIndex = 22;
            this.adminAddUsers_importBtn.Text = "IMPORT";
            this.adminAddUsers_importBtn.Click += new System.EventHandler(this.adminAddUsers_importBtn_Click);
            // 
            // adminAddUsers_clearBtn
            // 
            this.adminAddUsers_clearBtn.CheckedState.Parent = this.adminAddUsers_clearBtn;
            this.adminAddUsers_clearBtn.CustomImages.Parent = this.adminAddUsers_clearBtn;
            this.adminAddUsers_clearBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.adminAddUsers_clearBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminAddUsers_clearBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUsers_clearBtn.HoverState.Parent = this.adminAddUsers_clearBtn;
            this.adminAddUsers_clearBtn.Location = new System.Drawing.Point(135, 487);
            this.adminAddUsers_clearBtn.Name = "adminAddUsers_clearBtn";
            this.adminAddUsers_clearBtn.ShadowDecoration.Parent = this.adminAddUsers_clearBtn;
            this.adminAddUsers_clearBtn.Size = new System.Drawing.Size(92, 45);
            this.adminAddUsers_clearBtn.TabIndex = 20;
            this.adminAddUsers_clearBtn.Text = "CLEAR";
            this.adminAddUsers_clearBtn.Click += new System.EventHandler(this.adminAddUsers_clearBtn_Click);
            // 
            // adminAddUsers_deleteBtn
            // 
            this.adminAddUsers_deleteBtn.CheckedState.Parent = this.adminAddUsers_deleteBtn;
            this.adminAddUsers_deleteBtn.CustomImages.Parent = this.adminAddUsers_deleteBtn;
            this.adminAddUsers_deleteBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.adminAddUsers_deleteBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminAddUsers_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUsers_deleteBtn.HoverState.Parent = this.adminAddUsers_deleteBtn;
            this.adminAddUsers_deleteBtn.Location = new System.Drawing.Point(19, 487);
            this.adminAddUsers_deleteBtn.Name = "adminAddUsers_deleteBtn";
            this.adminAddUsers_deleteBtn.ShadowDecoration.Parent = this.adminAddUsers_deleteBtn;
            this.adminAddUsers_deleteBtn.Size = new System.Drawing.Size(92, 45);
            this.adminAddUsers_deleteBtn.TabIndex = 19;
            this.adminAddUsers_deleteBtn.Text = "DELETE";
            this.adminAddUsers_deleteBtn.Click += new System.EventHandler(this.adminAddUsers_deleteBtn_Click);
            // 
            // adminAddUsers_updateBtn
            // 
            this.adminAddUsers_updateBtn.CheckedState.Parent = this.adminAddUsers_updateBtn;
            this.adminAddUsers_updateBtn.CustomImages.Parent = this.adminAddUsers_updateBtn;
            this.adminAddUsers_updateBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.adminAddUsers_updateBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminAddUsers_updateBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUsers_updateBtn.HoverState.Parent = this.adminAddUsers_updateBtn;
            this.adminAddUsers_updateBtn.Location = new System.Drawing.Point(135, 421);
            this.adminAddUsers_updateBtn.Name = "adminAddUsers_updateBtn";
            this.adminAddUsers_updateBtn.ShadowDecoration.Parent = this.adminAddUsers_updateBtn;
            this.adminAddUsers_updateBtn.Size = new System.Drawing.Size(92, 45);
            this.adminAddUsers_updateBtn.TabIndex = 18;
            this.adminAddUsers_updateBtn.Text = "UPDATE";
            this.adminAddUsers_updateBtn.Click += new System.EventHandler(this.adminAddUsers_updateBtn_Click);
            // 
            // adminAddUsers_addBtn
            // 
            this.adminAddUsers_addBtn.CheckedState.Parent = this.adminAddUsers_addBtn;
            this.adminAddUsers_addBtn.CustomImages.Parent = this.adminAddUsers_addBtn;
            this.adminAddUsers_addBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.adminAddUsers_addBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminAddUsers_addBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddUsers_addBtn.HoverState.Parent = this.adminAddUsers_addBtn;
            this.adminAddUsers_addBtn.Location = new System.Drawing.Point(19, 421);
            this.adminAddUsers_addBtn.Name = "adminAddUsers_addBtn";
            this.adminAddUsers_addBtn.ShadowDecoration.Parent = this.adminAddUsers_addBtn;
            this.adminAddUsers_addBtn.Size = new System.Drawing.Size(92, 45);
            this.adminAddUsers_addBtn.TabIndex = 17;
            this.adminAddUsers_addBtn.Text = "ADD";
            this.adminAddUsers_addBtn.Click += new System.EventHandler(this.adminAddUsers_addBtn_Click);
            // 
            // adminAddUsers_status
            // 
            this.adminAddUsers_status.FormattingEnabled = true;
            this.adminAddUsers_status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Approval"});
            this.adminAddUsers_status.Location = new System.Drawing.Point(19, 372);
            this.adminAddUsers_status.Name = "adminAddUsers_status";
            this.adminAddUsers_status.Size = new System.Drawing.Size(208, 21);
            this.adminAddUsers_status.TabIndex = 16;
            // 
            // adminAddUsers_role
            // 
            this.adminAddUsers_role.FormattingEnabled = true;
            this.adminAddUsers_role.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.adminAddUsers_role.Location = new System.Drawing.Point(19, 316);
            this.adminAddUsers_role.Name = "adminAddUsers_role";
            this.adminAddUsers_role.Size = new System.Drawing.Size(208, 21);
            this.adminAddUsers_role.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Role";
            // 
            // adminAddUsers_password
            // 
            this.adminAddUsers_password.Location = new System.Drawing.Point(19, 258);
            this.adminAddUsers_password.Name = "adminAddUsers_password";
            this.adminAddUsers_password.Size = new System.Drawing.Size(208, 20);
            this.adminAddUsers_password.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // adminAddUsers_username
            // 
            this.adminAddUsers_username.Location = new System.Drawing.Point(19, 201);
            this.adminAddUsers_username.Name = "adminAddUsers_username";
            this.adminAddUsers_username.Size = new System.Drawing.Size(208, 20);
            this.adminAddUsers_username.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // adminAddUsers_imageView
            // 
            this.adminAddUsers_imageView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminAddUsers_imageView.Location = new System.Drawing.Point(71, 12);
            this.adminAddUsers_imageView.Name = "adminAddUsers_imageView";
            this.adminAddUsers_imageView.Size = new System.Drawing.Size(103, 108);
            this.adminAddUsers_imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminAddUsers_imageView.TabIndex = 21;
            this.adminAddUsers_imageView.TabStop = false;
            // 
            // AdminCashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(744, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminCashierForm";
            this.Text = "AdminCashierForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAddUsers_imageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button adminAddUsers_importBtn;
        private System.Windows.Forms.PictureBox adminAddUsers_imageView;
        private Guna.UI2.WinForms.Guna2Button adminAddUsers_clearBtn;
        private Guna.UI2.WinForms.Guna2Button adminAddUsers_deleteBtn;
        private Guna.UI2.WinForms.Guna2Button adminAddUsers_updateBtn;
        private Guna.UI2.WinForms.Guna2Button adminAddUsers_addBtn;
        private System.Windows.Forms.ComboBox adminAddUsers_status;
        private System.Windows.Forms.ComboBox adminAddUsers_role;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminAddUsers_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminAddUsers_username;
        private System.Windows.Forms.Label label1;
    }
}