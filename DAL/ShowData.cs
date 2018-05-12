using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ShowData : DAO
    {
        DataTable dt = new DataTable();

        public DataTable ShowProducts()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products",OpenCon());
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }


    }
}
