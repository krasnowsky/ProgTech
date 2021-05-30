using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.API
{
    public interface IEventModelView
    {
        int EventID { get; set; }
        DateTime? Date { get; set; }
        int? ProductID { get; set; }
        int? CustomerID { get; set; }
    }
}
