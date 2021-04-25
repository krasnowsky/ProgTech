using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Logic
{
    interface ILogic
    {
        void Create_New_Customer(String fname, String lname, int customer_id);

        void Add_Product_To_Cart(String name, int amount, int price, int value);

        int Buy(String name, int amount, int price);

        void Delivery_Of_Goods(String name, int price, int amount);
    }
}
