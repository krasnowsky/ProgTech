using System;
namespace small_shop.Data
{
    public class PurchaseEvent : Event
    {
        public PurchaseEvent(int id, Customer customer, Cart cart, DateTime timeStamp) : base(id, customer, cart, timeStamp)
        {
            customer.Get_Customer_Name();
            //carts[id].SmallShopData.Get_Final_Price_Of_The_Cart(id);
        }
    }
}
