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
            Product milk = new Product("milk", 50);

            Assert.AreEqual(50, milk.Get_Price());
        }

        [TestMethod()]
        public void ProductTestName()
        {
            Product milk = new Product("milk", 20);

            Assert.AreEqual("milk", milk.Get_Product_Name());
        }

        [TestMethod()]
        public void ProductTestSale()
        {
            Product milk = new Product("milk", 50);

            milk.Set_Sale(15);

            Assert.AreEqual(15, milk.Get_Price());
            Assert.AreEqual(true, milk.Get_Sale_State());
        }
    }
}