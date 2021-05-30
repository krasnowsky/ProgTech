using LibraryShop.API;
using LibraryShop.data_files;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest.Data
{
    [TestClass]
    public class EventTests
    {
        public IDataManager manager;

        [TestInitialize]
        public void Initialize()
        {
            manager = new DataManager();
        }

        [TestMethod]
        public void AddEventToDatabaseTest()
        {
            manager.NukeTheData();
            Assert.IsTrue(manager.AddCustomer(1, "Marcin Najman"));
            Assert.IsTrue(manager.AddProduct(1, "Chips"));

            Assert.IsTrue(manager.AddEvent(1, DateTime.Now, manager.GetProductByID(1).ProductID, manager.GetCustomer(1).Customer_id));

            Assert.IsTrue(manager.DeleteEvent(manager.GetEventByID(1).Event_id));
            Assert.IsTrue(manager.DeleteProduct(manager.GetProductByID(1).ProductID));
            Assert.IsTrue(manager.DeleteCustomer(manager.GetCustomer(1).Customer_id));
        }

        [TestMethod]
        public void UpdateEvent()
        {
            manager.NukeTheData();
            Assert.IsTrue(manager.AddCustomer(1, "Stanisław"));
            Assert.IsTrue(manager.AddCustomer(2, "Wyspiański"));
            Assert.IsTrue(manager.AddProduct(1, "Honey"));
            Assert.IsTrue(manager.AddProduct(2, "Water"));

            Assert.IsTrue(manager.GetProductByID(1).isAvaliable);

            Assert.IsTrue(manager.AddEvent(1, DateTime.Now, manager.GetProductByID(1).ProductID, manager.GetCustomer(1).Customer_id));

            Assert.IsTrue(manager.UpdateEventProduct(manager.GetEventByID(1).Event_id, 2));
            Assert.IsTrue(manager.UpdateEventCustomer(manager.GetEventByID(1).Event_id, 2));

            Assert.IsTrue(manager.GetProductByID(1).isAvaliable);

            Assert.IsTrue(manager.DeleteEvent(manager.GetEventByID(1).Event_id));
            Assert.IsTrue(manager.DeleteProduct(manager.GetProductByID(1).ProductID));
            Assert.IsTrue(manager.DeleteProduct(manager.GetProductByID(2).ProductID));
            Assert.IsTrue(manager.DeleteCustomer(manager.GetCustomer(1).Customer_id));
            Assert.IsTrue(manager.DeleteCustomer(manager.GetCustomer(2).Customer_id));
            manager.NukeTheData();
        }
    }
}
