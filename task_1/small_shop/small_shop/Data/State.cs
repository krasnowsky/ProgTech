using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public class State
    {
        private int Amount_Of_Good;
        private bool Is_Available;

        public State(int value, bool state)
        {
            this.Amount_Of_Good = value;
            this.Is_Available = state;
        }

        public int Get_Amount()
        {
            return Amount_Of_Good;
        }

        public void Set_Amount(int value)
        {
            this.Amount_Of_Good = value;
        }

        public void Change_Amount(int value)
        {
            this.Amount_Of_Good += value;
        }

        public bool Get_Availability()
        {
            return Is_Available;
        }

        public void Restock(int amount)
        {
            Is_Available = true;
            Amount_Of_Good = amount;
        }

        public void Purchase(int amount)
        {
            Is_Available = false;
            Amount_Of_Good -= amount;
        }
    }
}
