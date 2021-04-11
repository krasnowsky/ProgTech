using System;
using System.Collections.Generic;

namespace small_shop.Data
{
    //describes the current state of the cart
    public class Cart 
    {
        private int Final_Price;
        private List<int> Amounts_Of_Goods_In_Cart = new List<int>();
        private List<Product> Products_In_Cart = new List<Product>();

        public Cart() { }

        public void Add_To_Cart(String name, int amount, int price)
        {
            Product new_product = new Product(name, price);
            this.Products_In_Cart.Add(new_product);
            this.Amounts_Of_Goods_In_Cart.Add(amount);
        }

        public String Get_Good_Name(int value)
        {
            return this.Products_In_Cart[value].Get_Product_Name();
        }

        public int Get_Good_Amount(int value)
        {
            return this.Amounts_Of_Goods_In_Cart[value];
        }

        public int Get_Good_Final_Price()
        {
            for (int i = 0; i < Products_In_Cart.Count; i++)
            {
                Final_Price += Products_In_Cart[i].Get_Price() * Amounts_Of_Goods_In_Cart[i];
            }
            return Final_Price;
        }
    }
}
