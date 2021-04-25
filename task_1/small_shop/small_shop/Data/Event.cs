using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public abstract class Event
    {
        protected int ID;
        public DateTime TimeStamp { get; private set; }
        protected String First_Name_Of_Buyer;
        protected String Last_Name_Of_Buyer;
        protected String Product_Name;

        public Event(int id, Customer customer, DateTime timeStamp, Product product) 
        {
            ID = id;
            TimeStamp = timeStamp;
            First_Name_Of_Buyer = customer.Get_Customer_Name();
            Last_Name_Of_Buyer = customer.Get_Customer_Last_Name();
            Product_Name = product.Get_Product_Name();
        }

        public abstract void Change_Amount(String name, int value, int price);
    }
}
