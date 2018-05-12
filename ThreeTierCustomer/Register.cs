using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIZ;
using DAL;

namespace ThreeTierCustomer
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string regUser = txtRegUser.Text;
            string regPass = txtRegPass.Text;
            string regFullName = txtRegFullName.Text;

            AddData ad = new AddData();
            ad.AddUser(regUser,regPass, regFullName);
            MessageBox.Show("User Registered");

        }
    }
}
