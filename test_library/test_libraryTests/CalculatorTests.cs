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
        private int expectedDifference = 5;

        [TestMethod()]
        public void CalculatorAddition()
        {
            Calculator calculator = new Calculator();
            calculator.add(2, 3);
            Assert.AreEqual(expectedSum, calculator.getSum());
        }

        [TestMethod()]
        public void CalculatorSubstraction()
        {
            Calculator calculator = new Calculator();
            calculator.substract(7, 2);
            Assert.AreEqual(expectedDifference, calculator.getDifference());
        }
    }
}