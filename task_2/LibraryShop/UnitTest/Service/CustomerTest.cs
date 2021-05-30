using LibraryShop.API;
using LibraryShop.data_files;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.API;
using Service.data_files;

namespace UnitTest.Service
{
    [TestClass]
    public class CustomerTest
    {
        public IDataManager manager;
        public ICustomerService service;

        [TestInitialize]
        public void Initialize()
        {
            manager = new DataManager();
            service = new CustomerService(manager);
        }

        [TestMethod]
        public void AddCustomerToDatabaseTest()
        {
            manager.NukeTheData();
            Assert.IsTrue(service.AddCustomer(1, "Ja"));
            Assert.AreEqual(service.GetCustomer(1).Name, "Ja");
            Assert.AreEqual(service.GetCustomer(1).CustomerID, 1);

            Assert.IsTrue(service.DeleteCustomer(service.GetCustomer(1).CustomerID));
        }

        [TestMethod]
        public void UpdateCustomerTest()
        {
            manager.NukeTheData();
            Assert.IsTrue(service.AddCustomer(1, "Laska"));
            Assert.IsTrue(service.UpdateCustomer(service.GetCustomer(1).CustomerID, "Laska"));

            Assert.AreEqual(service.GetCustomer(1).Name, "Laska");
            Assert.AreEqual(service.GetCustomer(1).CustomerID, 1);

            Assert.IsTrue(service.DeleteCustomer(service.GetCustomer(1).CustomerID));
        }

        [TestMethod]
        public void AddSameCustomerTest()
        {
            manager.NukeTheData();
            Assert.IsTrue(service.AddCustomer(1, "Bolek"));
            Assert.IsFalse(service.AddCustomer(1, "Bolek"));

            Assert.IsTrue(service.DeleteCustomer(service.GetCustomer(1).CustomerID));
        }
    }
}
