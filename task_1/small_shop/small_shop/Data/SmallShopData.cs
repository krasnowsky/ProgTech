using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public class SmallShopData
    {
        private List<Customer> customers = new List<Customer>();
        private List<Cart> carts = new List<Cart>();
        //private List<Product> products = new List<Product>();
        private List<State> states = new List<State>();
        private List<Event> events = new List<Event>();
        public SmallShopData () { }

        public void Add_Customer(Customer new_customer, Cart new_cart)
        {
            this.customers.Add(new_customer);
            this.carts.Add(new_cart);
        }

        public void Add_Cart(Cart new_cart)
        {
            this.carts.Add(new_cart);
        }

        public int Get_Number_Of_Customer()
        {
            return this.customers.Count;
        }

        /*public void Add_Product(Product product)
        {
            this.products.Add(product);
        }

        //method to change a bit
        public void Remove_Product(String name)
        {
            this.products.RemoveAt(1);
        }*/
        
        public void Add_State(State state)
        {
            this.states.Add(state);
        } 

    }
}
