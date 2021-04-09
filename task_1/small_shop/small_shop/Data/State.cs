using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public class State
    {
        private int Amount_Of_Good;
        private bool Is_Available;

        public State() { }

        public int Get_Amount()
        {
            return Amount_Of_Good;
        }

        public void Set_Amount(int value)
        {
            this.Amount_Of_Good = value;
        }

        public bool Get_Availability()
        {
            return Is_Available;
        }

        public void Set_Availability(bool state)
        {
            this.Is_Available = state;
        }
    }
}
