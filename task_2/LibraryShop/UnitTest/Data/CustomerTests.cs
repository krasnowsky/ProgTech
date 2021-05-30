using LibraryShop.API;
using LibraryShop.data_files;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Data
{
    [TestClass]
    public class CustomerTests
    {
        public IDataManager manager;

        [TestInitialize]
        public void Initialize()
        {
            manager = new DataManager();
        }

        [TestMethod]
        public void AddCustomerToDatabaseTest()
        {
            manager.NukeTheData();
            Assert.IsTrue(manager.AddCustomer(1, "Parke"));
            Assert.AreEqual(manager.GetCustomer(1).Name, "Parke");
            Assert.AreEqual(manager.GetCustomer(1).Customer_id, 1);

            Assert.IsTrue(manager.DeleteCustomer(manager.GetCustomer(1).Customer_id));
            manager.NukeTheData();
        }

        [TestMethod]
        public void UpdateCustomerTest()
        {
            manager.NukeTheData();
            Assert.IsTrue(manager.AddCustomer(1, "Don papa"));
            Assert.IsTrue(manager.UpdateCustomer(manager.GetCustomer(1).Customer_id, "Koziołek"));

            Assert.AreEqual(manager.GetCustomer(1).Name, "Koziołek");
            Assert.AreEqual(manager.GetCustomer(1).Customer_id, 1);

            Assert.IsTrue(manager.DeleteCustomer(manager.GetCustomer(1).Customer_id));
            manager.NukeTheData();
        }

        [TestMethod]
        public void AddSameRCustomerTest()
        {
            manager.NukeTheData();
            Assert.IsTrue(manager.AddCustomer(1, "Reksio"));
            Assert.IsFalse(manager.AddCustomer(1, "Reksio"));

            Assert.IsTrue(manager.DeleteCustomer(manager.GetCustomer(1).Customer_id));
            manager.NukeTheData();
        }
    }
}
