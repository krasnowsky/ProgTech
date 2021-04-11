using System;

namespace small_shop.Logic
{
    public class SmallShopLogic
    {
        private Data.SmallShopData data = new Data.SmallShopData();
        public void Create_New_Customer(String fname, String lname, String customer_id)
        {
            data.Add_Customer(fname, lname, customer_id);
        }

        public void Add_Product_To_Cart(String name, int amount)
        {
            data.Add_Customer("John", "Smith", "1");
            data.Add_Product("milk", 7);
            data.Add_Good_To_Cart("milk", 2, 0);

        }

        public int Buy(String name, int amount)
        {     
            data.Change_Product_Amount(name, amount, -1);
            return data.Get_Price(data.Get_Good_Id(name));
        }

        public void Delivery_Of_Goods(String name, int price, int amount)
        { 
            data.Add_Product(name, price);
            data.Change_Product_Amount(name, amount, 1);
        }
    }
}
