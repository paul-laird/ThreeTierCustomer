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
using DAL;

namespace ThreeTierCustomer
{
    public partial class ShowCustomers : Form
    {
        DAO dao = new DAO();
        public ShowCustomers()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customer",dao.OpenCon());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem cus = new ListViewItem(dr["CustomerId"].ToString());
                cus.SubItems.Add(dr["Title"].ToString());
                cus.SubItems.Add(dr["FirstName"].ToString());
                cus.SubItems.Add(dr["LastName"].ToString());
                cus.SubItems.Add(dr["City"].ToString());

                myList.Items.Add(cus);
            }
            dao.CloseCon();
        }
    }
}
