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
        readonly DateTime date_1 = new DateTime(2020, 5, 10);
        public Event new_event = new Event(1, new Customer("Maria", "Golinska", "id1"), new Cart());

        [TestMethod()]
        public void EventTestCustomerName()
        {
            Assert.AreEqual("Maria", Customer.Get_Customer_Name());
            //new_event.Save_Customer_Data("Maria", 100, 1);
            //Assert.AreEqual(100, new_event.Get_Final_Price_Of_The_Cart(0));
        }
    }
}