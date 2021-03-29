using Microsoft.VisualStudio.TestTools.UnitTesting;
using test_library;
using System;
using System.Collections.Generic;
using System.Text;

namespace test_library.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private int expectedSum = 5;

        [TestMethod()]
        public void CalculatorTest()
        {
            Calculator calculator = new Calculator(3);
            calculator.add(2);
            Assert.AreEqual(expectedSum, calculator.getSum());
        }
    }
}