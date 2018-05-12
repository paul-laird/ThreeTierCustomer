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
    public partial class AddProductcs : Form
    {
        public AddProductcs()
        {
            InitializeComponent();
        }

        private void btnAddproduct_Click(object sender, EventArgs e)
        {
            string pname = txtproductName.Text;
            string ptype = cboType.SelectedItem.ToString();

            // instance of class and call a method
            AddNewProduct ap = new AddNewProduct(pname,ptype);
            ap.AddProdToDb();

            MessageBox.Show("product added to database");

            txtproductName.Clear();
            cboType.SelectedIndex = -1;

            

        }
    }
}
