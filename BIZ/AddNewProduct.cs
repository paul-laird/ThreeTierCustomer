using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BIZ
{
    public class AddNewProduct : AddData
    {
        public string ProductName { get; set; }
        public string ProductType { get; set; }

        public AddNewProduct(string pname, string ptype)
        {
            ProductName = pname;
            ProductType = ptype;
        }

        public void AddProdToDb()
        {
            AddProduct(ProductName,ProductType);
        }

    }
}
