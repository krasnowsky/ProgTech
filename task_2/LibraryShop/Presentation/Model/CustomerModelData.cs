using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.API;
using Service.API;

namespace Presentation.Model
{
    public class CustomerModelData : ICustomerModelData
    {
        public ICustomerService Service { get; }
        public CustomerModelData(ICustomerService service)
        {
            Service = service;
        }

        public IEnumerable<ICustomerData> Customer
        {
            get
            {
                IEnumerable<ICustomerData> customers = Service.GetCustomers();
                return customers;
            }
        }

        public ICustomerModelView CreateCustomer(string Name, int ID)
        {
            return new CustomerModelView(Name, ID);
        }
    }
}
