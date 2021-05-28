using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryShop.API;

namespace LibraryShop.data_files
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public int ProductID { get ; set; }
        public bool isAvaliable { get; set; }

        public Product(string name, int product_id)
        {
            Name = name;
            ProductID = product_id;
            isAvaliable = true;
        }
    }
}
