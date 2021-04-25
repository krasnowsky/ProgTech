using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public interface IData
    {
        void Add_Event(Event new_event);

        void Add_Good_To_Cart(String name, int amount, int price, int value);

        int Get_Final_Price_Of_The_Cart(int value);

        void Add_Customer(String fname, String lname, int customer_id);

        int GetEventsNumber();

        Cart Get_Cart(int value);

        int Get_Number_Of_Customer();

        int Get_Price(int value);

        void Add_Product(String name, int price);

        int Get_Good_Id(String name);

        void Change_Product_Amount(String name, int value, int price, int sign);

        int Get_Product_Amount(int value);

        void Add_State(int value, bool state);

        Customer Get_Customer(int value);
    }
}
