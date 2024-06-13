using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace system
{
    public partial class AdminMainForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\CMS.mdf;Integrated Security=True;Connect Timeout=30");

        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            username_name.Text = LoginForm.USER;

        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Sign out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                this.Hide();
            }
        }

        public void AddControls(Form f)
        {
            center_panel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            center_panel.Controls.Add(f);
            f.Show();
        }

        private void Cashier_btn_Click(object sender, EventArgs e)
        {
            AddControls(new AdminCashierForm());
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            AddControls(new AdminHomeBoardForm());
        }

        private void Products_btn_Click(object sender, EventArgs e)
        {
            AddControls(new AdminProductsForm());
        }

        private void Customers_btn_Click(object sender, EventArgs e)
        {
            AddControls(new CustomerForm());
        }
    }
}
