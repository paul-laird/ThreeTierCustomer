using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BIZ
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Login(string user, string pass)
        {
            Username = user;
            Password = pass;
        }

        CheckLogin cl = new CheckLogin();

        public string CheckUserPass()
        {
            string login = cl.CheckUser(Username, Password);
            if(login == "no")
            {
                return "no";
            }
            else
            {
                return login;
            }

        }

    }
}
