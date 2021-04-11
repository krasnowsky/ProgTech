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
            Data.SmallShopData data = new Data.SmallShopData();
            SmallShopLogic logic = new SmallShopLogic(data);
            logic.Create_New_Customer("John", "Smith", "1");
        }

        [TestMethod()]
        public void Delivery_Test()
        {
            Data.SmallShopData data = new Data.SmallShopData();
            SmallShopLogic logic = new SmallShopLogic(data);

            data.Add_Product("milk", 2);
            data.Add_State(10, true);

            logic.Delivery_Of_Goods("milk", 2, 20);

            Assert.AreEqual(30, data.Get_Product_Amount(0));
        }

        [TestMethod()]
        public void Add_Product_To_CartTest()
        {
            Data.SmallShopData data = new Data.SmallShopData();
            SmallShopLogic logic = new SmallShopLogic(data);

            logic.Create_New_Customer("John", "Smith", "1");

            data.Add_Product("milk", 2);
            data.Add_State(10, true);
            logic.Add_Product_To_Cart("milk", 5, 2, 0);

            data.Add_Product("water", 5);
            data.Add_State(20, true);
            logic.Add_Product_To_Cart("water", 10, 5, 0);

            Assert.AreEqual(60, data.Get_Final_Price_Of_The_Cart(0));
        }

        [TestMethod()]
        public void BuyTest()
        {
            Data.SmallShopData data = new Data.SmallShopData();
            SmallShopLogic logic = new SmallShopLogic(data);

            data.Add_Product("milk", 5);
            data.Add_State(100, true);

            Assert.AreEqual(50, logic.Buy("milk", 10, 5));
        }
    }
}