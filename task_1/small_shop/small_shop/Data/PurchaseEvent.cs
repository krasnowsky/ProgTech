using System;
namespace small_shop.Data
{
    public class PurchaseEvent : Event
    {
        public PurchaseEvent(int id, Customer customer, DateTime timeStamp, Product new_product) : base(id, customer, timeStamp, new_product)
        { 
        }
    }
}
