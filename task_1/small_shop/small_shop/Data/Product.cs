using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    //describes product of one type eg. tomatoes
    public class Product
    {
        private String IDD;
        private String Name;
        private int Amount;
        private int Price;
        private bool Is_On_Sale;

        public Product() { }

        public Product(String name)
        {
            this.Name = name;
            this.Is_On_Sale = false;
        }

        public Product(String name, int n_price)
        {
            this.Name = name;
            this.Price = n_price;
            this.Is_On_Sale = false;
        }

        public String Get_Product_Name()
        {
            return this.Name;
        }

        public void Set_Price(int price)
        {
            this.Price = price;
        }

        public int Get_Price()
        {
            return Price;
        }

        public void Set_Sale(int n_price)
        {
            this.Is_On_Sale = true;
            this.Price = n_price;
        }

        public bool Get_Sale_State()
        {
            return Is_On_Sale;
        }

        public void Set_Amount(int value)
        {
            this.Amount = value;
        }
    }
}
