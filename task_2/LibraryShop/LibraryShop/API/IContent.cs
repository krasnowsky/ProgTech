using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShop.API
{
    public interface IContent
    {
        IProduct ProductInstance { get; set; }

        int Quantity { get; set; }
    }
}
