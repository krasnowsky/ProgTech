using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShop.API
{
    public interface IEvent
    {
        int Event_id { get; set; }

        DateTime? Timestamp { get; set; }

        int? Product_id { get; set; }

        int? Customer_id { get; set; }
    }
}
