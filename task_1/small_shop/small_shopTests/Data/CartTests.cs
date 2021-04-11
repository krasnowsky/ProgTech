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
        private Cart new_cart = new Cart();

        [TestMethod()]
        public void CartTestsNameOfGood()
        {
            new_cart.Add_To_Cart("milk", 50, 2);

            Assert.AreEqual("milk", new_cart.Get_Good_Name(0));
        }
    }
}