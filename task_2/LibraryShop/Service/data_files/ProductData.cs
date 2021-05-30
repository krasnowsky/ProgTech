using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;

namespace Service.data_files
{
    public class ProductData : IProductData
    {
        public string Name { get; set; }
        public int ProductID { get; set; }
        public bool isAvaliable { get; set; }
    }
}
