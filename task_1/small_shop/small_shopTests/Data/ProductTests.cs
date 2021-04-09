using Microsoft.VisualStudio.TestTools.UnitTesting;
using small_shop.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void ProductTestPrice()
        {
            Product milk = new Product("milk", "liquid", "19.02.2000", "19.03.2000");
            milk.setPrice(50);

            Assert.AreEqual(50, milk.getPrice());
        }

        [TestMethod()]
        public void ProductTestName()
        {
            Product milk = new Product("milk", "liquid", "19.02.2000", "19.03.2000");

            Assert.AreEqual("milk", milk.Get_Product_Name());
        }

        [TestMethod()]
        public void ProductTestSale()
        {
            Product milk = new Product("milk", "liquid", "19.02.2000", "19.03.2000");

            milk.setPrice(20);
            milk.setSale(15);

            Assert.AreEqual(15, milk.getPrice());
            Assert.AreEqual(true, milk.getSaleState());
        }
    }
}