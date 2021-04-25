using System;

namespace small_shop.Logic
{
    public class Logic
    {
        private Data.Data data;
        public Logic(Data.Data outside_data)
        {
            data = outside_data;
        }

        public void Create_New_Customer(String fname, String lname, int customer_id)
        {
            data.Add_Customer(fname, lname, customer_id);
        }

        public void Add_Product_To_Cart(String name, int amount, int price, int value)
        {
            data.Add_Good_To_Cart(name, amount, price, value);
        }

        public int Buy(String name, int amount, int price)
        {     
            data.Change_Product_Amount(name, amount, price, -1);
            return amount*data.Get_Price(data.Get_Good_Id(name));
        }

        public void Delivery_Of_Goods(String name, int price, int amount)
        { 
            data.Add_Product(name, price);
            data.Change_Product_Amount(name, amount, price, 1);
        }
    }
}
