using LibraryShop.API;
using LibraryShop.data_files;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.data_files;

namespace UnitTest.Service
{
    [TestClass]
    public class ProductTests
    {
        public IDataManager manager;
        public ProductService service;

        [TestInitialize]
        public void Initialize()
        {
            manager = new DataManager();
            service = new ProductService(manager);
        }
        [TestMethod]
        public void AddProductToDatabaseTest()
        {
            manager.NukeTheData();
            Assert.IsTrue(service.AddProduct(1, "Milk"));
            Assert.AreEqual(service.GetProductByID(1).Name, "Milk");
            Assert.AreEqual(service.GetProductByID(1).ProductID, 1);
            Assert.AreEqual(service.GetProductByID(1).isAvaliable, true);

            Assert.IsTrue(service.DeleteProduct(service.GetProductByID(1).ProductID));
            manager.NukeTheData();
        }

        [TestMethod]
        public void AddSameProductToDatabaseTest()
        {
            manager.NukeTheData();
            Assert.IsTrue(service.AddProduct(1, "Honey"));
            Assert.IsFalse(service.AddProduct(1, "Honey"));

            Assert.IsTrue(service.DeleteProduct(service.GetProductByID(1).ProductID));
            manager.NukeTheData();
        }

        [TestMethod]
        public void GetProductsByName()
        {
            manager.NukeTheData();
            Assert.IsTrue(service.AddProduct(1, "Water"));
            Assert.IsTrue(service.AddProduct(2, "Chocolate"));
            Assert.IsTrue(service.DeleteProduct(service.GetProductByID(1).ProductID));
            Assert.IsTrue(service.DeleteProduct(service.GetProductByID(2).ProductID));
            manager.NukeTheData();
        }
    }
}