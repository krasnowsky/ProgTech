using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryShop.API;

namespace LibraryShop.data_files
{
    class Content : IContent
    {
        public IProduct ProductInstance { get; set; }
        public int Quantity { get; set; }

        public Content(IProduct productInstance, int quantity)
        {
            ProductInstance = productInstance;
            Quantity = quantity;
        }
    }
}
