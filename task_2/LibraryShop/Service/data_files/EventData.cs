using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryShop.API;
using LibraryShop.data_files;
using Service.API;

namespace Service.data_files
{
    class EventData : IEventData
    {
        public int EventID { get; set; }
        public DateTime? Date { get; set; }
        public int? ProductID { get; set; }
        public int? CustomerID { get; set; }
    }
}
