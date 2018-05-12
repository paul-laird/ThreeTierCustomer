using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BIZ;

namespace ThreeTierCustomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            Login l = new Login(user, pass);
            string status = l.CheckUserPass();

            if(status == "no")
            {
                MessageBox.Show("failed to Login");
            }
            else
            {
                MessageBox.Show("Success");
                lblDisplay.Text = "Welcome " + status;
                txtUser.Enabled = false;
                txtPass.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                btnLogin.Enabled = false;
                btnReg.Enabled = false;
            }

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer();
            ac.ShowDialog();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductcs ap = new AddProductcs();
            ap.ShowDialog();
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCustomers sc = new ShowCustomers();
            sc.ShowDialog();
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProductscs sp = new ShowProductscs();
            sp.ShowDialog();
        }
    }
}
