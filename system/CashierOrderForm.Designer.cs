namespace system
{
    partial class CashierOrderForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cashierOrderForm_menuTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cashierOrderForm_price = new System.Windows.Forms.Label();
            this.cashierOrderForm_prodName = new System.Windows.Forms.Label();
            this.cashierOrderForm_clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cashierOrderForm_removeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cashierOrderForm_addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cashierOrderForm_quantity = new System.Windows.Forms.NumericUpDown();
            this.cashierOrderForm_productID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cashierOrderForm_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cashierOrderForm_orderTable = new System.Windows.Forms.DataGridView();
            this.cashierOrderForm_receiptBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cashierOrderForm_payBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cashierOrderForm_change = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cashierOrderForm_amount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cashierOrderForm_orderPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_menuTable)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_quantity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_orderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cashierOrderForm_menuTable);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 345);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // cashierOrderForm_menuTable
            // 
            this.cashierOrderForm_menuTable.AllowUserToAddRows = false;
            this.cashierOrderForm_menuTable.AllowUserToDeleteRows = false;
            this.cashierOrderForm_menuTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cashierOrderForm_menuTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cashierOrderForm_menuTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cashierOrderForm_menuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierOrderForm_menuTable.EnableHeadersVisualStyles = false;
            this.cashierOrderForm_menuTable.Location = new System.Drawing.Point(16, 59);
            this.cashierOrderForm_menuTable.Name = "cashierOrderForm_menuTable";
            this.cashierOrderForm_menuTable.ReadOnly = true;
            this.cashierOrderForm_menuTable.RowHeadersVisible = false;
            this.cashierOrderForm_menuTable.Size = new System.Drawing.Size(685, 265);
            this.cashierOrderForm_menuTable.TabIndex = 2;
            this.cashierOrderForm_menuTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cashierOrderForm_menuTable_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.cashierOrderForm_price);
            this.panel2.Controls.Add(this.cashierOrderForm_prodName);
            this.panel2.Controls.Add(this.cashierOrderForm_clearBtn);
            this.panel2.Controls.Add(this.cashierOrderForm_removeBtn);
            this.panel2.Controls.Add(this.cashierOrderForm_addBtn);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cashierOrderForm_quantity);
            this.panel2.Controls.Add(this.cashierOrderForm_productID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cashierOrderForm_type);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 239);
            this.panel2.TabIndex = 2;
            // 
            // cashierOrderForm_price
            // 
            this.cashierOrderForm_price.AutoSize = true;
            this.cashierOrderForm_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_price.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_price.Location = new System.Drawing.Point(125, 138);
            this.cashierOrderForm_price.Name = "cashierOrderForm_price";
            this.cashierOrderForm_price.Size = new System.Drawing.Size(0, 18);
            this.cashierOrderForm_price.TabIndex = 31;
            // 
            // cashierOrderForm_prodName
            // 
            this.cashierOrderForm_prodName.AutoSize = true;
            this.cashierOrderForm_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_prodName.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_prodName.Location = new System.Drawing.Point(125, 81);
            this.cashierOrderForm_prodName.Name = "cashierOrderForm_prodName";
            this.cashierOrderForm_prodName.Size = new System.Drawing.Size(0, 18);
            this.cashierOrderForm_prodName.TabIndex = 18;
            // 
            // cashierOrderForm_clearBtn
            // 
            this.cashierOrderForm_clearBtn.CheckedState.Parent = this.cashierOrderForm_clearBtn;
            this.cashierOrderForm_clearBtn.CustomImages.Parent = this.cashierOrderForm_clearBtn;
            this.cashierOrderForm_clearBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.cashierOrderForm_clearBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashierOrderForm_clearBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_clearBtn.HoverState.Parent = this.cashierOrderForm_clearBtn;
            this.cashierOrderForm_clearBtn.Location = new System.Drawing.Point(471, 179);
            this.cashierOrderForm_clearBtn.Name = "cashierOrderForm_clearBtn";
            this.cashierOrderForm_clearBtn.ShadowDecoration.Parent = this.cashierOrderForm_clearBtn;
            this.cashierOrderForm_clearBtn.Size = new System.Drawing.Size(120, 45);
            this.cashierOrderForm_clearBtn.TabIndex = 29;
            this.cashierOrderForm_clearBtn.Text = "CLEAR";
            this.cashierOrderForm_clearBtn.Click += new System.EventHandler(this.cashierOrderForm_clearBtn_Click);
            // 
            // cashierOrderForm_removeBtn
            // 
            this.cashierOrderForm_removeBtn.CheckedState.Parent = this.cashierOrderForm_removeBtn;
            this.cashierOrderForm_removeBtn.CustomImages.Parent = this.cashierOrderForm_removeBtn;
            this.cashierOrderForm_removeBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.cashierOrderForm_removeBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashierOrderForm_removeBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_removeBtn.HoverState.Parent = this.cashierOrderForm_removeBtn;
            this.cashierOrderForm_removeBtn.Location = new System.Drawing.Point(309, 179);
            this.cashierOrderForm_removeBtn.Name = "cashierOrderForm_removeBtn";
            this.cashierOrderForm_removeBtn.ShadowDecoration.Parent = this.cashierOrderForm_removeBtn;
            this.cashierOrderForm_removeBtn.Size = new System.Drawing.Size(120, 45);
            this.cashierOrderForm_removeBtn.TabIndex = 28;
            this.cashierOrderForm_removeBtn.Text = "REMOVE";
            this.cashierOrderForm_removeBtn.Click += new System.EventHandler(this.cashierOrderForm_removeBtn_Click);
            // 
            // cashierOrderForm_addBtn
            // 
            this.cashierOrderForm_addBtn.CheckedState.Parent = this.cashierOrderForm_addBtn;
            this.cashierOrderForm_addBtn.CustomImages.Parent = this.cashierOrderForm_addBtn;
            this.cashierOrderForm_addBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.cashierOrderForm_addBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashierOrderForm_addBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_addBtn.HoverState.Parent = this.cashierOrderForm_addBtn;
            this.cashierOrderForm_addBtn.Location = new System.Drawing.Point(148, 179);
            this.cashierOrderForm_addBtn.Name = "cashierOrderForm_addBtn";
            this.cashierOrderForm_addBtn.ShadowDecoration.Parent = this.cashierOrderForm_addBtn;
            this.cashierOrderForm_addBtn.Size = new System.Drawing.Size(120, 45);
            this.cashierOrderForm_addBtn.TabIndex = 27;
            this.cashierOrderForm_addBtn.Text = "ADD";
            this.cashierOrderForm_addBtn.Click += new System.EventHandler(this.cashierOrderForm_addBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(49, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Price ($):";
            // 
            // cashierOrderForm_quantity
            // 
            this.cashierOrderForm_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_quantity.Location = new System.Drawing.Point(448, 83);
            this.cashierOrderForm_quantity.Name = "cashierOrderForm_quantity";
            this.cashierOrderForm_quantity.Size = new System.Drawing.Size(208, 29);
            this.cashierOrderForm_quantity.TabIndex = 25;
            this.cashierOrderForm_quantity.ValueChanged += new System.EventHandler(this.cashierOrderForm_quantity_ValueChanged);
            // 
            // cashierOrderForm_productID
            // 
            this.cashierOrderForm_productID.FormattingEnabled = true;
            this.cashierOrderForm_productID.Items.AddRange(new object[] {
            "Meal",
            "Drinks"});
            this.cashierOrderForm_productID.Location = new System.Drawing.Point(448, 20);
            this.cashierOrderForm_productID.Name = "cashierOrderForm_productID";
            this.cashierOrderForm_productID.Size = new System.Drawing.Size(208, 21);
            this.cashierOrderForm_productID.TabIndex = 24;
            this.cashierOrderForm_productID.SelectedIndexChanged += new System.EventHandler(this.cashierOrderForm_productID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Product Name:";
            // 
            // cashierOrderForm_type
            // 
            this.cashierOrderForm_type.FormattingEnabled = true;
            this.cashierOrderForm_type.Items.AddRange(new object[] {
            "Meal",
            "Drinks"});
            this.cashierOrderForm_type.Location = new System.Drawing.Point(127, 20);
            this.cashierOrderForm_type.Name = "cashierOrderForm_type";
            this.cashierOrderForm_type.Size = new System.Drawing.Size(208, 21);
            this.cashierOrderForm_type.TabIndex = 22;
            this.cashierOrderForm_type.SelectedIndexChanged += new System.EventHandler(this.cashierOrderForm_type_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(368, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(368, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Product ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(77, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.cashierOrderForm_orderTable);
            this.panel3.Controls.Add(this.cashierOrderForm_receiptBtn);
            this.panel3.Controls.Add(this.cashierOrderForm_payBtn);
            this.panel3.Controls.Add(this.cashierOrderForm_change);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.cashierOrderForm_amount);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cashierOrderForm_orderPrice);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(748, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 591);
            this.panel3.TabIndex = 4;
            // 
            // cashierOrderForm_orderTable
            // 
            this.cashierOrderForm_orderTable.AllowUserToAddRows = false;
            this.cashierOrderForm_orderTable.AllowUserToDeleteRows = false;
            this.cashierOrderForm_orderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cashierOrderForm_orderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cashierOrderForm_orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cashierOrderForm_orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierOrderForm_orderTable.EnableHeadersVisualStyles = false;
            this.cashierOrderForm_orderTable.Location = new System.Drawing.Point(17, 13);
            this.cashierOrderForm_orderTable.Name = "cashierOrderForm_orderTable";
            this.cashierOrderForm_orderTable.ReadOnly = true;
            this.cashierOrderForm_orderTable.RowHeadersVisible = false;
            this.cashierOrderForm_orderTable.Size = new System.Drawing.Size(340, 366);
            this.cashierOrderForm_orderTable.TabIndex = 46;
            this.cashierOrderForm_orderTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cashierOrderForm_orderTable_CellContentClick);
            // 
            // cashierOrderForm_receiptBtn
            // 
            this.cashierOrderForm_receiptBtn.CheckedState.Parent = this.cashierOrderForm_receiptBtn;
            this.cashierOrderForm_receiptBtn.CustomImages.Parent = this.cashierOrderForm_receiptBtn;
            this.cashierOrderForm_receiptBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.cashierOrderForm_receiptBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashierOrderForm_receiptBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_receiptBtn.HoverState.Parent = this.cashierOrderForm_receiptBtn;
            this.cashierOrderForm_receiptBtn.Location = new System.Drawing.Point(201, 518);
            this.cashierOrderForm_receiptBtn.Name = "cashierOrderForm_receiptBtn";
            this.cashierOrderForm_receiptBtn.ShadowDecoration.Parent = this.cashierOrderForm_receiptBtn;
            this.cashierOrderForm_receiptBtn.Size = new System.Drawing.Size(114, 45);
            this.cashierOrderForm_receiptBtn.TabIndex = 45;
            this.cashierOrderForm_receiptBtn.Text = "RECEIPT";
            // 
            // cashierOrderForm_payBtn
            // 
            this.cashierOrderForm_payBtn.CheckedState.Parent = this.cashierOrderForm_payBtn;
            this.cashierOrderForm_payBtn.CustomImages.Parent = this.cashierOrderForm_payBtn;
            this.cashierOrderForm_payBtn.FillColor = System.Drawing.Color.SlateBlue;
            this.cashierOrderForm_payBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashierOrderForm_payBtn.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_payBtn.HoverState.Parent = this.cashierOrderForm_payBtn;
            this.cashierOrderForm_payBtn.Location = new System.Drawing.Point(68, 518);
            this.cashierOrderForm_payBtn.Name = "cashierOrderForm_payBtn";
            this.cashierOrderForm_payBtn.ShadowDecoration.Parent = this.cashierOrderForm_payBtn;
            this.cashierOrderForm_payBtn.Size = new System.Drawing.Size(114, 45);
            this.cashierOrderForm_payBtn.TabIndex = 44;
            this.cashierOrderForm_payBtn.Text = "PAY";
            this.cashierOrderForm_payBtn.Click += new System.EventHandler(this.cashierOrderForm_payBtn_Click);
            // 
            // cashierOrderForm_change
            // 
            this.cashierOrderForm_change.AutoSize = true;
            this.cashierOrderForm_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_change.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_change.Location = new System.Drawing.Point(108, 465);
            this.cashierOrderForm_change.Name = "cashierOrderForm_change";
            this.cashierOrderForm_change.Size = new System.Drawing.Size(16, 18);
            this.cashierOrderForm_change.TabIndex = 40;
            this.cashierOrderForm_change.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(17, 465);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 18);
            this.label13.TabIndex = 38;
            this.label13.Text = "Change ($):";
            // 
            // cashierOrderForm_amount
            // 
            this.cashierOrderForm_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_amount.Location = new System.Drawing.Point(108, 422);
            this.cashierOrderForm_amount.Name = "cashierOrderForm_amount";
            this.cashierOrderForm_amount.Size = new System.Drawing.Size(128, 26);
            this.cashierOrderForm_amount.TabIndex = 43;
            this.cashierOrderForm_amount.TextChanged += new System.EventHandler(this.cashierOrderForm_amount_TextChanged);
            this.cashierOrderForm_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cashierOrderForm_amount_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(17, 426);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 42;
            this.label11.Text = "Amount ($):";
            // 
            // cashierOrderForm_orderPrice
            // 
            this.cashierOrderForm_orderPrice.AutoSize = true;
            this.cashierOrderForm_orderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_orderPrice.ForeColor = System.Drawing.Color.White;
            this.cashierOrderForm_orderPrice.Location = new System.Drawing.Point(98, 390);
            this.cashierOrderForm_orderPrice.Name = "cashierOrderForm_orderPrice";
            this.cashierOrderForm_orderPrice.Size = new System.Drawing.Size(16, 18);
            this.cashierOrderForm_orderPrice.TabIndex = 41;
            this.cashierOrderForm_orderPrice.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "Price ($):";
            // 
            // CashierOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1136, 615);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierOrderForm";
            this.Text = "CashierOrderForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_menuTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_quantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_orderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView cashierOrderForm_menuTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cashierOrderForm_type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown cashierOrderForm_quantity;
        private System.Windows.Forms.ComboBox cashierOrderForm_productID;
        private Guna.UI2.WinForms.Guna2Button cashierOrderForm_clearBtn;
        private Guna.UI2.WinForms.Guna2Button cashierOrderForm_removeBtn;
        private Guna.UI2.WinForms.Guna2Button cashierOrderForm_addBtn;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button cashierOrderForm_receiptBtn;
        private Guna.UI2.WinForms.Guna2Button cashierOrderForm_payBtn;
        private System.Windows.Forms.Label cashierOrderForm_change;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cashierOrderForm_amount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label cashierOrderForm_orderPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView cashierOrderForm_orderTable;
        private System.Windows.Forms.Label cashierOrderForm_price;
        private System.Windows.Forms.Label cashierOrderForm_prodName;
    }
}