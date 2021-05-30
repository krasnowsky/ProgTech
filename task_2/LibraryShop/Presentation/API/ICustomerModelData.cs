using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;

namespace Presentation.API
{
    public interface ICustomerModelData
    {
        ICustomerService Service { get; }
        IEnumerable<ICustomerData> Customer { get; }
        ICustomerModelView CreateCustomer(string Name, int ID);
    }
}
