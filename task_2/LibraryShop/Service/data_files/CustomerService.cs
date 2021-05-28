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
    class CustomerService : ICustomerService
    {
        private IDataManager manager;

        public CustomerService(IDataManager manager)
        {
            this.manager = manager;
        }

        public CustomerService()
        {
            this.manager = new DataManager();
        }

        public ICustomerData Transfer(ICustomer customer)
        {
            if (customer == null)
            {
                return null;
            }

            return new CustomerData
            {
                Name = customer.Name,
                CustomerID = customer.Customer_id,
            };
        }

        public IEnumerable<ICustomerData> GetCustomers()
        {
            var customers = manager.GetCustomers();
            var result = new List<ICustomerData>();

            foreach (var customer in customers)
            {
                result.Add(Transfer(customer));
            }

            return result;
        }

        public ICustomerData GetCustomer(int ID)
        {
            return Transfer(manager.GetCustomer(ID));
        }

        public bool AddCustomer(int ID, string Name)
        {
            return manager.AddCustomer(ID, Name);
        }

        public bool UpdateCustomer(int ID, string Name)
        {
            return manager.UpdateCustomer(ID, Name);
        }

        public bool DeleteCustomer(int ID)
        {
            return manager.DeleteCustomer(ID);
        }
    }
}
