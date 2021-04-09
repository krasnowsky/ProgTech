using Microsoft.VisualStudio.TestTools.UnitTesting;
using small_shop.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data.Tests
{
    [TestClass()]
    public class StateTests
    {
        [TestMethod()]
        public void StateAmountTest()
        {
            small_shop.Data.State state = new small_shop.Data.State();

            state.Set_Amount(20);

            Assert.AreEqual(20, state.Get_Amount());
        }

        [TestMethod()]
        public void StateAvailabilityTest()
        {
            small_shop.Data.State state = new small_shop.Data.State();

            state.Set_Availability(true);

            Assert.AreEqual(true, state.Get_Availability());
        }
    }
}