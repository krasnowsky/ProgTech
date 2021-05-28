using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShop.API
{
    public interface ICustomer
    {
        string Name { get; set; }

        int Customer_id { get; set; }
    }
}
