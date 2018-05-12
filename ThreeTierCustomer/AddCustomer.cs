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

namespace ThreeTierCustomer
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string city = txtCity.Text;

            // method to call from BIZ
            AddNewCustomer ac = new AddNewCustomer(title,fname,lname,city);
            ac.AddCusToDb();


            txtTitle.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtCity.Clear();

            MessageBox.Show("Customer added to database");
        }
    }
}
