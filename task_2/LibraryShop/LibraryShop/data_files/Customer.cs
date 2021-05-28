using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryShop.API;

namespace LibraryShop.data_files
{
    class Customer : ICustomer
    {
        public string Name { get; set; }
        public int Customer_id { get; set; }

        public Customer(string name, int customer_id)
        {
            Name = name;
            Customer_id = customer_id;
        }
    }
}
