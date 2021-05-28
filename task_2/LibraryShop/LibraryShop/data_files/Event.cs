using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryShop.API;

namespace LibraryShop.data_files
{
    class Event : IEvent
    {
        public int Event_id { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? Product_id { get; set; }
        public int? Customer_id { get; set; }

        public Event( int event_id, DateTime? date, int? product_id, int? customer_id)
        {
            Event_id = event_id;
            Timestamp = date;
            Product_id = product_id;
            Customer_id = customer_id;
        }

    }
}
