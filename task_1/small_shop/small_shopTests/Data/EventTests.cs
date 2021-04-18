using Microsoft.VisualStudio.TestTools.UnitTesting;
using small_shop.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data.Tests
{ 
    [TestClass()]
    public class EventTests
    {

        static DateTime date_1 = new DateTime(2020, 5, 10);
        static DateTime date_2 = new DateTime(2020, 10, 12);
        public Event new_event = new PurchaseEvent(1, new Customer("Maria", "Golinska", 1), new Cart(), date_1);

        [TestMethod()]
        public void EventTestEventsNumber()
        {

            Assert.AreEqual(1, SmallShopData.GetEventsNumber());

        }

        [TestMethod()]
        public void EventTestCustomerData()
        {

            Assert.AreEqual("Maria", SmallShopData.GetEvent(1).Customer.Name);
            Assert.AreEqual("Golinska", SmallShopData.GetEvent(1).Customer.Surname);

        }
    }
}