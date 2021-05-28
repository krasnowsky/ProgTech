using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    interface ICustomerService
    {
        IEnumerable<ICustomerData> GetCustomers();
        ICustomerData GetCustomer(int ID);
        bool AddCustomer(int ID, string Name);
        bool UpdateCustomer(int ID, string Name);
        bool DeleteCustomer(int ID);
    }
}
