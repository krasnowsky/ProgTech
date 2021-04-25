using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public abstract class Event
    {
        protected int ID;
        protected int Amount;
        public DateTime TimeStamp { get; private set; }
        protected String First_Name_Of_Buyer;
        protected String Last_Name_Of_Buyer;
        protected String Product_Name;
        protected State state;

        public Event(int id, Customer customer, DateTime timeStamp, Product product, State state, int amount) 
        {
            ID = id;
            TimeStamp = timeStamp;
            First_Name_Of_Buyer = customer.Get_Customer_Name();
            Last_Name_Of_Buyer = customer.Get_Customer_Last_Name();
            Product_Name = product.Get_Product_Name();
            this.state = state;
            Amount = amount;
        }

        public int Get_ID()
        {
            return ID;
        }

        public String Get_First_Name()
        {
            return First_Name_Of_Buyer;
        }
    }
}
