using LibraryShop.API;
using LibraryShop.data_files;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.API;
using Service.data_files;
using System;

namespace UnitTest.Service
{
    [TestClass]
    public class EventTests
    {
        public IDataManager manager;
        public ICustomerService customerService;
        public IProductService productService;
        public IEventService eventService;

        [TestInitialize]
        public void Initialize()
        {
            manager = new DataManager();
            customerService = new CustomerService(manager);
            productService = new ProductService(manager);
            eventService = new EventService(manager);
        }

        [TestMethod]
        public void AddEventToDatabaseTest()
        {
            manager.NukeTheData();
            Assert.IsTrue(customerService.AddCustomer(1, "Marek"));
            Assert.IsTrue(productService.AddProduct(1, "Milk"));

            Assert.AreEqual(1, productService.GetProductByID(1).ProductID);
            Assert.AreEqual(1, customerService.GetCustomer(1).CustomerID);

            Assert.IsTrue(eventService.AddEvent(1, DateTime.Now, productService.GetProductByID(1).ProductID, customerService.GetCustomer(1).CustomerID));

            Assert.IsTrue(eventService.DeleteEvent(eventService.GetEventByID(1).EventID));
            Assert.IsTrue(productService.DeleteProduct(productService.GetProductByID(1).ProductID));
            Assert.IsTrue(customerService.DeleteCustomer(customerService.GetCustomer(1).CustomerID));
        }

        [TestMethod]
        public void UpdateEvent()
        {
            manager.NukeTheData();
            Assert.IsTrue(customerService.AddCustomer(1, "Wojtek"));
            Assert.IsTrue(customerService.AddCustomer(2, "Maria"));
            Assert.IsTrue(productService.AddProduct(1, "Water"));
            Assert.IsTrue(productService.AddProduct(2, "Juice"));

            Assert.IsTrue(productService.GetProductByID(1).isAvaliable);

            Assert.IsTrue(eventService.AddEvent(1, DateTime.Now, productService.GetProductByID(1).ProductID, customerService.GetCustomer(1).CustomerID));

            Assert.IsTrue(eventService.UpdateEventProduct(eventService.GetEventByID(1).EventID, 2));
            Assert.IsTrue(eventService.UpdateEventCustomer(eventService.GetEventByID(1).EventID, 2));

            Assert.IsTrue(productService.GetProductByID(1).isAvaliable);

            Assert.IsTrue(eventService.DeleteEvent(manager.GetEventByID(1).Event_id));
            Assert.IsTrue(productService.DeleteProduct(productService.GetProductByID(1).ProductID));
            Assert.IsTrue(productService.DeleteProduct(productService.GetProductByID(2).ProductID));
            Assert.IsTrue(customerService.DeleteCustomer(customerService.GetCustomer(1).CustomerID));
            Assert.IsTrue(customerService.DeleteCustomer(customerService.GetCustomer(2).CustomerID));
        }
    }
}
