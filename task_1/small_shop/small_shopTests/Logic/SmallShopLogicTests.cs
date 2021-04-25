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
            Data.Data data = new Data.Data();
            Logic logic = new Logic(data);
            logic.Create_New_Customer("John", "Smith", 1);
        }

        [TestMethod()]
        public void Delivery_Test()
        {
            Data.Data data = new Data.Data();
            Logic logic = new Logic(data);

            data.Add_Product("milk", 2);
            data.Add_State(10, true);

            logic.Delivery_Of_Goods("milk", 2, 20);

            Assert.AreEqual(30, data.Get_Product_Amount(0));
        }

        [TestMethod()]
        public void Add_Product_To_CartTest()
        {
            Data.Data data = new Data.Data();
            Logic logic = new Logic(data);

            logic.Create_New_Customer("John", "Smith", 1);

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
            Data.Data data = new Data.Data();
            Logic logic = new Logic(data);

            Data.Customer new_customer = new Data.Customer("Jon", "Smith", 1);
            
            data.Add_Product("milk", 5);
            data.Add_State(100, true);

            Data.PurchaseEvent new_event = new Data.PurchaseEvent(1, new_customer, DateTime.Now, new Data.Product("milk"));
            data.Add_Event(new_event);

            Assert.AreEqual(50, logic.Buy("milk", 10, 5));
        }

        [TestMethod()]
        public void EventAdditionTest()
        {
            Data.Data data = new Data.Data();
            Logic logic = new Logic(data);

            Data.PurchaseEvent new_event = new Data.PurchaseEvent(1, new Data.Customer("Jon", "Smith", 1), DateTime.Now, new Data.Product("milk"));

            data.Add_Event(new_event);

            Assert.AreEqual(1, new_event.Get_ID());
        }

        [TestMethod()]
        public void EventRestockTest()
        {
            Data.Data data = new Data.Data();
            Logic logic = new Logic(data);

            Data.RestockEvent new_event = new Data.RestockEvent(1, new Data.Customer("Jon", "Smith", 1), DateTime.Now, new Data.Product("milk"));

            data.Add_Event(new_event);

            Assert.AreEqual("Jon", new_event.Get_First_Name());
        }
    }
}