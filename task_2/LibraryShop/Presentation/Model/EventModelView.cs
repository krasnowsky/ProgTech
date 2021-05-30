using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.API; 

namespace Presentation.Model
{
    public class EventModelView : IEventModelView
    {
        public int EventID { get; set; }
        public DateTime? Date { get; set; }
        public int? ProductID { get; set; }
        public int? CustomerID { get; set; }

        public EventModelView(int eventID, DateTime? date, int? productID, int? customerID)
        {
            EventID = eventID;
            Date = date;
            ProductID = productID;
            CustomerID = customerID;
        }
    }
}
