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
    public partial class ShowProductscs : Form
    {
        public ShowProductscs()
        {
            InitializeComponent();
        }

        private void ShowProductscs_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadProducts_Click(object sender, EventArgs e)
        {
            ShowProd sp = new ShowProd();
            dgv.DataSource = sp.Getproducts();
        }
    }
}
