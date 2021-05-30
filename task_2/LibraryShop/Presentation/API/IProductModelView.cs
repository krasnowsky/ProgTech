using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.API
{
    public interface IProductModelView
    {
        string Name { get; set; }
        int ProductID { get; set; }
        bool isAvailable { get; set; }
    }
}
