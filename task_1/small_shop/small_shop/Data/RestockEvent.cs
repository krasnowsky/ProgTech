using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public class RestockEvent : Event
    {
        public RestockEvent(int id, Customer customer, DateTime timeStamp, Product restock_product, State new_state, int new_amount) : base(id, customer, timeStamp, restock_product, new_state, new_amount) 
        {
            new_state.Restock(new_amount);
        }
    }
}
