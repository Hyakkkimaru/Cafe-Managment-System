﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace system
{
    public partial class CashierOrderForm : Form
    {
        public static int getCustID;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\CMS.mdf;Integrated Security=True;Connect Timeout=30");

        public CashierOrderForm()
        {
            InitializeComponent();

            displayAvailableProds();
            displayAllOrders();

            displayTotalPrice();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAvailableProds();
            displayAllOrders();

            displayTotalPrice();
        }

        public void displayAvailableProds()
        {
            CashierOrderFormProdData allProds = new CashierOrderFormProdData();

            List<CashierOrderFormProdData> listData = allProds.availableProductsData();

            cashierOrderForm_menuTable.DataSource = listData;
        }

        public void displayAllOrders()
        {
            CashierOrdersData allOrders = new CashierOrdersData();

            List<CashierOrdersData> listData = allOrders.ordersListData();

            cashierOrderForm_orderTable.DataSource = listData;
        }

        private float totalPrice;

        public void displayTotalPrice()
        {
            IDGenerator();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT SUM(prod_price) FROM orders WHERE customer_id = @custId";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@custId", idGen);

                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);

                            cashierOrderForm_orderPrice.Text = totalPrice.ToString("0.00");
                        }
                        else
                        {

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void cashierOrderForm_addBtn_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (cashierOrderForm_type.SelectedIndex == -1 || cashierOrderForm_productID.SelectedIndex == -1
                || cashierOrderForm_prodName.Text == "" || cashierOrderForm_quantity.Value == 0
                || cashierOrderForm_price.Text == "")
            {
                MessageBox.Show("Please select the product first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        float getPrice = 0;
                        string selectOrder = "SELECT * FROM products WHERE prod_id = @prodID";

                        using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                        {
                            getOrder.Parameters.AddWithValue("@prodID", cashierOrderForm_productID.Text.Trim());

                            using (SqlDataReader reader = getOrder.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    object rawValue = reader["prod_price"];
                                    if (rawValue != DBNull.Value)
                                    {
                                        getPrice = Convert.ToSingle(rawValue);
                                    }
                                }
                            }
                        }

                        string insertOrder = "INSERT INTO orders (customer_id, prod_id, prod_name, prod_type, qty, prod_price, order_date) " +
                            "VALUES(@customerID, @prodID, @prodName, @prodType, @qty, @prodPrice, @orderDate)";

                        DateTime today = DateTime.Today;

                        using (SqlCommand cmd = new SqlCommand(insertOrder, connect))
                        {
                            cmd.Parameters.AddWithValue("@customerID", idGen);
                            cmd.Parameters.AddWithValue("@prodID", cashierOrderForm_productID.Text.Trim());
                            cmd.Parameters.AddWithValue("@prodName", cashierOrderForm_prodName.Text);
                            cmd.Parameters.AddWithValue("@prodType", cashierOrderForm_type.Text.Trim());

                            float totalPrice = (getPrice * (int)cashierOrderForm_quantity.Value);

                            cmd.Parameters.AddWithValue("@qty", cashierOrderForm_quantity.Value);
                            cmd.Parameters.AddWithValue("@prodPrice", totalPrice);
                            cmd.Parameters.AddWithValue("@orderDate", today);

                            cmd.ExecuteNonQuery();


                            displayAllOrders();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            displayTotalPrice();
        }

        private int idGen = 0;
        public void IDGenerator()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\CMS.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                string selectID = "SELECT MAX(customer_id) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectID, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int temp = Convert.ToInt32(result);

                        if (temp == 0)
                        {
                            idGen = 1;
                        }
                        else
                        {
                            idGen = temp + 1;
                        }
                    }
                    else
                    {
                        idGen = 1;
                    }
                    getCustID = idGen;
                }
            }
        }

        private void cashierOrderForm_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            cashierOrderForm_productID.SelectedIndex = -1;
            cashierOrderForm_productID.Items.Clear();
            cashierOrderForm_prodName.Text = "";
            cashierOrderForm_price.Text = "";



            string selectedValue = cashierOrderForm_type.SelectedItem as string;

            if (selectedValue != null)
            {

                try
                {
                    using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\CMS.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        connect.Open();
                        string selectData = $"SELECT * FROM products WHERE prod_type = '{selectedValue}' AND prod_status = @status AND date_delete IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["prod_id"].ToString();

                                    cashierOrderForm_productID.Items.Add(value);
                                }
                            }
                        }
                    }
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Error: " + exx, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cashierOrderForm_productID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cashierOrderForm_productID.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\CMS.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        connect.Open();
                        string selectData = $"SELECT * FROM products WHERE prod_id = '{selectedValue}' AND prod_status = @status AND date_delete IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["prod_name"].ToString();
                                    string prodPrice = reader["prod_price"].ToString();

                                    cashierOrderForm_prodName.Text = prodName;
                                    cashierOrderForm_price.Text = prodPrice;

                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cashierOrderForm_quantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cashierOrderForm_amount_TextChanged(object sender, EventArgs e)
        {
        }

        private void cashierOrderForm_payBtn_Click(object sender, EventArgs e)
        {
            if (cashierOrderForm_amount.Text == "" || cashierOrderForm_orderTable.Rows.Count < 0)
            {
                MessageBox.Show("Something went wrong.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure for paying?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();

                            IDGenerator();


                            string insertData = "INSERT INTO customers (customer_id, total_price, amount, change, date) " +
                                "VALUES(@custID, @totalprice, @amount, @change, @date)";

                            DateTime today = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@custID", idGen);
                                cmd.Parameters.AddWithValue("@totalprice", totalPrice);
                                cmd.Parameters.AddWithValue("@amount", cashierOrderForm_amount.Text);
                                cmd.Parameters.AddWithValue("@change", cashierOrderForm_change.Text);
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Paid successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
            displayTotalPrice();
        }

        private int rowIndex = 0;

        private void cashierOrderForm_removeBtn_Click(object sender, EventArgs e)
        {
            if (getOrderID == 0)
            {
                MessageBox.Show("Select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove the Order ID: " + getOrderID + "?", "Confirmation Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM orders WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", getOrderID);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Removed successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }

            displayAllOrders();
            displayTotalPrice();
        }

        private int getOrderID = 0;

        private void cashierOrderForm_orderTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = cashierOrderForm_orderTable.Rows[e.RowIndex];
            getOrderID = (int)row.Cells[0].Value;
        }

        public void clearFields()
        {
            cashierOrderForm_type.SelectedIndex = -1;
            cashierOrderForm_productID.Items.Clear();
            cashierOrderForm_prodName.Text = "";
            cashierOrderForm_price.Text = "";
            cashierOrderForm_quantity.Value = 0;
        }

        private void cashierOrderForm_clearBtn_Click(object sender, EventArgs e)
        {
            displayAllOrders();
            displayTotalPrice();

            clearFields();
        }

        private void cashierOrderForm_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(cashierOrderForm_amount.Text);

                    float getChange = (getAmount - totalPrice);

                    if (getChange <= -1)
                    {
                        cashierOrderForm_amount.Text = "";
                        cashierOrderForm_change.Text = "";
                    }
                    else
                    {
                        cashierOrderForm_change.Text = getChange.ToString();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cashierOrderForm_amount.Text = "";
                    cashierOrderForm_change.Text = "";
                }
            }
        }
    }
}
