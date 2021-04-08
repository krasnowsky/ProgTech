using System;

namespace test_library
{
    public class Calculator
    {
        private int sum;
        private int difference;

        public Calculator() {
        }

        public void add(int a, int b)
        {
            sum = a + b;
        }

        public int getSum()
        {
            return sum;
        }

        public void substract(int a, int b)
        {
            difference = a - b;
        }

        public int getDifference()
        {
            return difference;
        }
    }
}

