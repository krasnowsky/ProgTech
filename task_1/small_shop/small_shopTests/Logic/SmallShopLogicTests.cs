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
        [TestMethod()]
        public void Create_New_CustomerTest()
        {
            SmallShopLogic logic = new SmallShopLogic();
            logic.Create_New_Customer("John", "Smith", "1");
        }
    }
}