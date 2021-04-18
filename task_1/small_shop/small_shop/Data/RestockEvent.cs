using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public class RestockEvent : Event
    {
        public RestockEvent(int id, Customer customer, DateTime timeStamp, Product restock_product) : base(id, customer, timeStamp, restock_product) { }
    }
}
