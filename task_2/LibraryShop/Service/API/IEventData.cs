using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    interface IEventData
    {
        int EventID { get; set; }
        DateTime? Date { get; set; }
        int? ProductID { get; set; }
        int? CustomerID { get; set; }
    }
}
