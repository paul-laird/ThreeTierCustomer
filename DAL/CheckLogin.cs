using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CheckLogin : DAO
    {
        public string UserLoginName { get; set; }

        public string CheckUser(string user, string pass)
        {
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserName=@user AND Password=@pass", OpenCon() );
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);

            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                return UserLoginName = dr.GetString(3);
            }
            else
            {
                string no = "no";
                return no;
            }

        }





    }
}
