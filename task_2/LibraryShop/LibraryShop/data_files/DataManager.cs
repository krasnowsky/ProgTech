using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryShop.API;
using LibraryShop.data_files;
using LibraryShop;

namespace LibraryShop.data_files
{
    public class DataManager : IDataManager
    {
        private ShopDataContext context;

        public DataManager() {

            context = new ShopDataContext();
        }

        public ICustomer Transform(Customers Customer)
        {
            return new Customer(Customer.name, Customer.id);
        }

        public IProduct Transform(Products Product)
        {
            return new Product(Product.name, Product.id);
        }

        public IEvent Transform(Events Event)
        {
            return new Event(Event.id, Event.date, Event.product_id, Event.customer_id);
        }

        #region Customer
        public IEnumerable<ICustomer> GetCustomers()
        {
            var customersDatabase = from Customers in context.Customers select Customers;
            List<ICustomer> customers_list = new List<ICustomer>();
            foreach (Customers Customer in customersDatabase)
            {
                customers_list.Add(Transform(Customer));
            }
            return customers_list;
        }

        public ICustomer GetCustomer(int ID)
        {
            var customerDatabase = (from customer in context.Customers where (customer.id == ID) select customer).FirstOrDefault();
            if (customerDatabase != null)
            {
                return Transform(customerDatabase);
            }
            return null;
        }

        public bool AddCustomer(int ID, string Name)
        {
            if (GetCustomer(ID) == null && !Name.Equals(null))
            {
                Customers NewReader = new Customers
                {
                    name = Name,
                    id = ID
                };
                context.Customers.InsertOnSubmit(NewReader);
                context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateCustomer(int ID, string Name)
        {
            Customers Customer = context.Customers.Where(customer => customer.id == ID).SingleOrDefault();
            if (GetCustomer(ID) != null && !Name.Equals(null))
            {
                Customer.name = Name;
                Customer.id = ID;
                context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool DeleteCustomer(int ID)
        {
            Customers Customer = context.Customers.Where(customer => customer.id == ID).SingleOrDefault();
            if (GetCustomer(ID) != null && !ID.Equals(null))
            {
                context.Customers.DeleteOnSubmit(Customer);
                context.SubmitChanges();
                return true;
            }
            return false;
        }
        #endregion

        #region Product
        public IEnumerable<IProduct> GetProducts()
        {
            var productsDatabase = from productDatabase in context.Products select productDatabase;
            List<IProduct> list = new List<IProduct>();
            foreach (Products Product in productsDatabase)
            {
                list.Add(Transform(Product));
            }
            return list;
        }

        public IProduct GetProductByID(int ID)
        {
            var productDatabase = (from product in context.Products where (product.id == ID) select product).FirstOrDefault();
            if (productDatabase != null)
            {
                return Transform(productDatabase);
            }
            return null;
        }

        public IProduct GetProductByName(string Name)
        {
            var productDatabase = (from product in context.Products where (product.name == Name) select product).SingleOrDefault();
            if (productDatabase != null)
            {
                return Transform(productDatabase);
            }
            return null;
        }

        public bool AddProduct(int ID, string Name)
        {
            if (GetProductByName(Name) == null && !Name.Equals(null) && !ID.Equals(null) && GetProductByID(ID) == null)
            {
                Products NewProduct = new Products
                {
                    id = ID,
                    name = Name,
                    isAvaliable = true,
                };
                context.Products.InsertOnSubmit(NewProduct);
                context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateProduct(int ID, string Name)
        {
            Products Product = context.Products.Where(i => i.id == ID).SingleOrDefault();
            if (!ID.Equals(null) && !Name.Equals(null) && GetProductByID(ID) != null)
            {
                Product.id = ID;
                Product.name = Name;
                context.SubmitChanges();
                return true;
            }
            return false;
        }

        public void ReturnProduct(int? ID)
        {
            Products Product = context.Products.Where(i => i.id == ID).SingleOrDefault();
            if (GetProductByID(ID.GetValueOrDefault()) != null && !ID.Equals(null))
            {
                Product.isAvaliable = true;
                context.SubmitChanges();
            }
        }

        public bool DeleteProduct(int ID)
        {
            Products Product = context.Products.Where(i => i.id == ID).SingleOrDefault();
            if (GetProductByID(ID) != null && !ID.Equals(null))
            {
                context.Products.DeleteOnSubmit(Product);
                context.SubmitChanges();
                return true;
            }
            return false;
        }
        #endregion

        #region Event

        public IEnumerable<IEvent> GetEvents()
        {
            var eventsDb = from eventDb in context.Events select eventDb;
            List<IEvent> list = new List<IEvent>();
            foreach (Events Event in eventsDb)
            {
                list.Add(Transform(Event));
            }
            return list;
        }

        public IEvent GetEventByID(int ID)
        {
            var eventDb = (from temp in context.Events where (temp.id == ID) select temp).SingleOrDefault();
            if (eventDb != null)
            {
                return Transform(eventDb);
            }
            return null;
        }

        public IEnumerable<IEvent> GetEventsByCustomerID(int Customer_id)
        {
            var eventDb = from temp in context.Events where (temp.customer_id == Customer_id) select temp;
            List<IEvent> list = new List<IEvent>();
            foreach (Events Event in eventDb)
            {
                if (Event.customer_id.Equals(Customer_id))
                {
                    list.Add(Transform(Event));
                }
            }
            return list;
        }

        public bool AddEvent(int EventID, DateTime Date, int ProductID, int CustomerID)
        {
            if (!EventID.Equals(null) && !Date.Equals(null) && !ProductID.Equals(null) && !CustomerID.Equals(null))
            {
                Products Product = context.Products.Where(i => i.id == ProductID).SingleOrDefault();
                Customers Customer = context.Customers.Where(i => i.id == CustomerID).SingleOrDefault();
                if (GetProductByID(ProductID) != null && GetCustomer(CustomerID) != null && GetEventByID(EventID) == null)
                {
                    Product.isAvaliable = false;

                    Events NewEvent = new Events
                    {
                        id = EventID,
                        date = Date,
                        product_id = ProductID,
                        customer_id = CustomerID,
                    };
                    context.Events.InsertOnSubmit(NewEvent);
                    context.SubmitChanges();
                    return true;
                }
            }
            return false;
        }

        //MAY NOT WORK
        public bool UpdateEventProduct(int ID, int ProductID)
        {
            var eventDb = (from temp in context.Events where (temp.id == ID) select temp).SingleOrDefault();
            if (!ProductID.Equals(null))
            {
                ReturnProduct(eventDb.product_id);
                eventDb.product_id = ProductID;
                context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateEventCustomer(int ID, int CustomerID)
        {
            var eventDb = (from temp in context.Events where (temp.id == ID) select temp).SingleOrDefault();
            if (!CustomerID.Equals(null) && GetEventByID(ID) != null)
            {
                eventDb.customer_id = CustomerID;
                context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool DeleteEvent(int ID)
        {
            var eventDb = (from temp in context.Events where (temp.id == ID) select temp).SingleOrDefault();
            if (GetEventByID(ID) != null && !ID.Equals(null))
            {
                ReturnProduct(eventDb.product_id);
                context.Events.DeleteOnSubmit(eventDb);
                context.SubmitChanges();
                return true;
            }
            return false;
        }
        #endregion

    }
}
