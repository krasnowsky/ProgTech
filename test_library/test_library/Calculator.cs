using System;

namespace test_library
{
    public class Calculator
    {
        private int sum;
        private int initialValue;

        public Calculator(int value) {
            initialValue = value;
        }

        public void add(int a)
        {
            sum = a + initialValue;
        }

        public int getSum()
        {
            return sum;
        }
    }
}
