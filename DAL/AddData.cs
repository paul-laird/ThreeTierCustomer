using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class AddData : DAO
    {
        public void AddUser (string uname, string upass, string ufullname)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Users (UserName,Password,FullName) VALUES (@uname,@pass,@fullname)",OpenCon());
            cmd.Parameters.AddWithValue("@uname", uname);
            cmd.Parameters.AddWithValue("@pass", upass);
            cmd.Parameters.AddWithValue("@fullname", ufullname);
            cmd.ExecuteNonQuery();
            CloseCon();
        }


        public void AddNewCus(string ti, string fn, string ln, string cy)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Customer (Title,FirstName,LastName,City) VALUES (@ti, @fn, @ln, @cy)",OpenCon());
            cmd.Parameters.AddWithValue("@ti", ti);
            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@ln", ln);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void AddProduct(string pn, string pt)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Products (ProductName,ProductType) VALUES (@pn, @pt)", OpenCon());
            cmd.Parameters.AddWithValue("@pn", pn);
            cmd.Parameters.AddWithValue("@pt", pt);
            cmd.ExecuteNonQuery();
            CloseCon();
        }

    }
}
