using Microsoft.VisualStudio.TestTools.UnitTesting;
using small_shop.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data.Tests
{
    [TestClass()]
    public class SmallShopDataTests
    {
        [TestMethod()]
        public void AddCustomerTest()
        {
            SmallShopData small_shop = new SmallShopData();
            Customer John = new Customer("John", "Smith", "1");
            Cart Johns_Cart = new Cart();

            small_shop.Add_Customer(John, Johns_Cart);

            Assert.AreEqual(1, small_shop.Get_Number_Of_Customer());
        }
    }
}