using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public class Event
    {
        //private List<SmallShopData> Event_Customer_Name = new List<SmallShopData>();
        //private List<SmallShopData> Event_Customer_Cart = new List<SmallShopData>();
        //private List<SmallShopData> Event_Customer_Price = new List<SmallShopData>();
        //private List<Customer> Event_Customer_Time = new List<Customer>();

        public int ID { get; set; }
        public Customer Customer { get; set; }
        public Cart Cart { get; set; }
        public DateTime TimeStamp { get; private set; }

        public Event(DateTime timeStamp)
        {
            TimeStamp = timeStamp;
        }

        public Event(int id, Customer customer, Cart cart, DateTime timeStamp) 
        {
            ID = id;
            Customer = customer;
            Cart = cart;
            TimeStamp = timeStamp;
        }
        

       /* public void Save_Customer_Data(String name, int price_value, int value)
        {
           // Event_Customer_Name[value].Get_Customer_Name();
            Event_Customer_Price[value].Get_Final_Price_Of_The_Cart(value);
           // Event_Customer_Cart[value].Get_Cart(value);
        }
       */
    }
}
