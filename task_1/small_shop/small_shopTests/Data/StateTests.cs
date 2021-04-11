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
            State state = new State(20, true);

            Assert.AreEqual(20, state.Get_Amount());
        }

        [TestMethod()]
        public void StateAvailabilityTest()
        {
            State state = new State(20, true);

            Assert.AreEqual(true, state.Get_Availability());
        }
    }
}