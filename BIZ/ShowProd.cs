using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BIZ
{
    public class ShowProd
    {
        public DataTable Getproducts()
        {
            ShowData sd = new ShowData();
            return sd.ShowProducts();
        }

    }
}
