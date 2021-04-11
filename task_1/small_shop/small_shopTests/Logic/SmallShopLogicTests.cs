using Microsoft.VisualStudio.TestTools.UnitTesting;
using small_shop.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Logic.Tests
{
    [TestClass()]
    public class SmallShopLogicTests
    {

        private SmallShopLogic logic = new SmallShopLogic();
        private Data.SmallShopData data = new Data.SmallShopData();

        [TestMethod()]
        public void Create_New_CustomerTest()
        {
            logic.Create_New_Customer("John", "Smith", "1");
        }

        /*[TestMethod()]
        public void BuyTest()
        {
            data.Add_Product("milk", 5);
            data.Add_State(100, true);
          
            Assert.AreEqual(10, logic.Buy("milk", 2));
        }*/


    }
}