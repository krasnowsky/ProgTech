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
            Cart new_cart = new Cart();

            Product milk = new Product("milk", 15);
            new_cart.Add_To_Cart(milk, 50);

            Product water = new Product("water", 2);
            new_cart.Add_To_Cart(water, 10);

            Assert.AreEqual(15*50+2*10, new_cart.Get_Good_Final_Price());
            //Assert.AreEqual("water", new_cart.Get_Good_Name(1));
        }

        [TestMethod()]
        public void CartTestsNameOfGood()
        {
            Cart new_cart = new Cart();

            Product milk = new Product("milk", 15);
            new_cart.Add_To_Cart(milk, 50);

            Assert.AreEqual("milk", new_cart.Get_Good_Name(0));
        }
    }
}