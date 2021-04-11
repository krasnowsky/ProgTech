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
        private SmallShopData data = new SmallShopData();
        [TestMethod()]
        public void AddCustomerTest()
        {
            data.Add_Customer("John", "Smith", "1");

            Assert.AreEqual(1, data.Get_Number_Of_Customer());
        }

        [TestMethod()]
        public void GetPriceTest()
        {
            data.Add_Product("milk", 7);

            Assert.AreEqual(7, data.Get_Price(0));
        }

        [TestMethod()]
        public void ChangeAmountTest()
        {
            data.Add_Product("milk", 7);
            data.Add_State(20, true);
            data.Change_Product_Amount("milk", 10, -1);

            Assert.AreEqual(10, data.Get_Product_Amount(0));
        }

        [TestMethod()]
        public void GetIdTest()
        {
            data.Add_Product("milk", 5);

            data.Add_Product("water", 5);

            Assert.AreEqual(1, data.Get_Good_Id("water"));
        }
    }
}