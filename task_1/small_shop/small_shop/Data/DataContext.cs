using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public class DataContext
    {
        public List<Customer> customers = new List<Customer>();
        public List<Cart> carts = new List<Cart>();
        public List<Product> products = new List<Product>();
        public List<State> states = new List<State>();
        public List<Event> events = new List<Event>();
    }
}
