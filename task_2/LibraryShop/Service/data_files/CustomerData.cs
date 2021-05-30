using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryShop.API;
using LibraryShop.data_files;
using Service.API;

namespace Service.data_files
{
    public class CustomerData : ICustomerData
    {
        public string Name { get; set; }
        public int CustomerID { get; set; }
    }
}
