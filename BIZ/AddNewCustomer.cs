using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BIZ 
{
    public class AddNewCustomer
    {
        AddData ad = new AddData();
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City{ get; set; }

        public AddNewCustomer(string title, string fname, string lname, string city)
        {
            Title = title;
            FirstName = fname;
            LastName = lname;
            City = city;
        }

        public void AddCusToDb()
        {
            ad.AddNewCus(Title, FirstName, LastName, City);
        }




    }
}
