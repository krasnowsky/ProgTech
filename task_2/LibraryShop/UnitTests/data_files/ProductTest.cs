using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryShop.data_files;
using System;
using System.Collections.Generic;
using System.Text;
using LibraryShop.API;

namespace LibraryShop.data_files.Tests
{
    [TestClass()]
    public class ProductTest
    {
        public IDataManager manager;

        [TestInitialize]
        public void Initialize()
        {
            manager = new DataManager();
        }

        [TestMethod]
        public void AddProductToDatabaseTest()
        {
            Assert.IsTrue(manager.AddProduct(1, "Milk"));
            Assert.AreEqual(manager.GetProductByID(1).Name, "Milk");
            Assert.AreEqual(manager.GetProductByID(1).isAvaliable, true);

            Assert.IsTrue(manager.DeleteProduct(manager.GetProductByID(1).ProductID));
        }

        [TestMethod]
        public void AddSameProductToDatabaseTest()
        {
            Assert.IsTrue(manager.AddProduct(1, "Milk"));
            Assert.IsFalse(manager.AddProduct(1, "Milk"));

            Assert.IsTrue(manager.DeleteProduct(manager.GetProductByID(1).ProductID));
        }
    }
}