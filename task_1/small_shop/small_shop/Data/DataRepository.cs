using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public class DataRepository : IData
    {
        private DataContext context;

        public DataRepository(DataContext new_context) 
        {
            this.context = new_context;
        }

        public void Add_Customer(String fname, String lname, int customer_id)
        {
            Customer new_customer = new Customer(fname, lname, customer_id);
            context.customers.Add(new_customer);

            Cart new_cart = new Cart();
            context.carts.Add(new_cart);
        }

        public void Add_Event(Event new_event)
        {
            context.events.Add(new_event);
        }

        public void Add_Good_To_Cart(String name, int amount, int price, int value)
        {
            context.carts[value].Add_To_Cart(name, amount, price);
        }

        public int Get_Final_Price_Of_The_Cart(int value)
        {
           return context.carts[value].Get_Good_Final_Price();
        }

        public int GetEventsNumber()
        {
            return context.events.Count;
        }

        public Cart Get_Cart(int value)
        {
            return context.carts[value];
        }

        public int Get_Number_Of_Customer()
        {
            return context.customers.Count;
        }

        public int Get_Price(int value)
        {
            return context.products[value].Get_Price();
        }

        public void Add_Product(String name, int price)
        {
            Product new_product = new Product(name, price);
            if(context.products.Count == 0) this.context.products.Add(new_product);
            else
            {
                for (int i = 0; i < context.products.Count; i++)
                {
                    if (context.products[i].Get_Product_Name() == name && context.products[i].Get_Price() == price) break;
                    else context.products.Add(new_product);
                }
            }
        }

        public int Get_Good_Id(String name)
        {
            for(int i = 0; i< context.products.Count; i++)
            {
                if(context.products[i].Get_Product_Name() == name)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Change_Product_Amount(String name, int value, int price, int sign)
        {
            for (int i = 0; i < context.products.Count; i++)
            {
                if (context.products[i].Get_Product_Name() == name && context.products[i].Get_Price() == price)
                {
                    context.states[i].Change_Amount(sign*value);
                }
                else
                {
                    State new_state = new State(sign*value, true);
                    context.states.Add(new_state);
                }
            }
        }

        public int Get_Product_Amount(int value)
        {
            return context.states[value].Get_Amount();
        }

        public void Add_State(int value, bool state)
        {
            State new_state = new State(value, state);
            context.states.Add(new_state);
        } 
    }
}
