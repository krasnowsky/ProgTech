using Microsoft.VisualStudio.TestTools.UnitTesting;
using small_shop.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CartTestsAmount()
        {
            Cart milk = new Cart("milk", 5, 20);

            Assert.AreEqual("milk", milk.Get_Good_Name());
        }
    }
}