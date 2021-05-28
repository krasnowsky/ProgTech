using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    interface IProductData
    {
        string Name { get; set; }

        int ProductID { get; set; }

        bool isAvaliable { get; set; }
    }
}
