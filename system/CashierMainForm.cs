using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system
{
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
        }

        private void CashierMainForm_Load(object sender, EventArgs e)
        {
            username_name.Text = LoginForm.USER;
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to sign out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private void home_btn_Click(object sender, EventArgs e)
        {
            AddControls(new AdminHomeBoardForm());
        }

        private void Order_btn_Click(object sender, EventArgs e)
        {
            AddControls(new CashierOrderForm());
        }

        private void Products_btn_Click(object sender, EventArgs e)
        {

        }

        private void Customers_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
