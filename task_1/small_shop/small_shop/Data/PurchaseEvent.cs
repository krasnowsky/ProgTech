using System;
namespace small_shop.Data
{
    public class PurchaseEvent : Event
    {
        public PurchaseEvent(int id, Customer customer, DateTime timeStamp, Product new_product, State new_state, int amount) : base(id, customer, timeStamp, new_product, new_state, amount) 
        {
            new_state.Purchase(amount);
        }
    }
}
