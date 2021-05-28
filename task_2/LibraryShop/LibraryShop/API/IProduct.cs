using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShop.API
{
    public interface IProduct
    {
        string Name { get; set; }

        int ProductID { get; set; }

        bool isAvaliable { get; set; }
    }
}
