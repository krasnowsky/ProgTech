using System;
namespace small_shop.Data
{
    public class PurchaseEvent : Event
    {
        public PurchaseEvent(int id, Customer customer, DateTime timeStamp, Product new_product) : base(id, customer, timeStamp, new_product) { }

        override public void Change_Amount(String name, int value, int price)
        {
            for (int i = 0; i < context.products.Count; i++)
            {
                if (context.products[i].Get_Product_Name() == name && context.products[i].Get_Price() == price)
                {
                    context.states[i].Change_Amount(sign * value);
                }
                else
                {
                    State new_state = new State(sign * value, true);
                    context.states.Add(new_state);
                }
            }
        }

    }
}
