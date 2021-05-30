using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.API;

namespace Presentation.Model
{
    class CustomerModelView : ICustomerModelView
    {
        public string Name { get; set; }
        public int CustomerID { get; set; }

        public CustomerModelView(string name, int customerID)
        {
            Name = name;
            CustomerID = customerID;
        }
    }
}
