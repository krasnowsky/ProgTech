using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public class SmallShopData
    {
        private List<Customer> customers = new List<Customer>();
        private List<Cart> carts = new List<Cart>();
        private List<Product> products;
        private List<State> states;
        private List<Event> events;
        public SmallShopData () { }

        public void Add_Customer(Customer new_customer, Cart new_cart)
        {
            this.customers.Add(new_customer);
            this.carts.Add(new_cart);
        }

        public int Get_Number_Of_Customer()
        {
            return this.customers.Count;
        }


    }
}
