using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShop.API
{
    public interface IDataManager
    {
        ICustomer Transform(Customers Customer);
        IProduct Transform(Products Product);
        IEvent Transform(Events Event);

        #region Customer
        IEnumerable<ICustomer> GetCustomers();
        ICustomer GetCustomer(int ID);
        bool AddCustomer(int ID, string Name);
        bool UpdateCustomer(int ID, string Name);
        bool DeleteCustomer(int ID);
        #endregion

        #region Product
        IEnumerable<IProduct> GetProducts();
        IProduct GetProductByID(int ID);
        IProduct GetProductByName(string Name);
        bool AddProduct(int ID, string Name);
        bool UpdateProduct(int ID, string Name);
        bool DeleteProduct(int ID);
        #endregion

        #region Event
        IEnumerable<IEvent> GetEvents();
        IEvent GetEventByID(int ID);
        IEnumerable<IEvent> GetEventsByCustomerID(int customer_id);
        bool AddEvent(int event_id, DateTime date, int product_id, int customer_id);
        bool UpdateEventProduct(int ID, int product_id);
        bool UpdateEventCustomer(int ID, int customer_id);
        bool DeleteEvent(int ID);
        #endregion
    }
}
