using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public class Product
    {
        private String IDD;
        private String Name;
        private String Type;
        private String Production_Date;
        private String Expiration_Date;
        private int Price;
        private bool Is_On_Sale;

        public Product() { }

        public Product(String name, String type, String pro_d, String exp_d)
        {
            this.Name = name;
            this.Type = type;
            this.Production_Date = pro_d;
            this.Expiration_Date = exp_d;
            this.Is_On_Sale = false;
        }

        public String Get_Product_Name()
        {
            return this.Name;
        }

        public String Get_Product_Type()
        {
            return this.Type;
        }

        public void setPrice(int price)
        {
            this.Price = price;
        }

        public int getPrice()
        {
            return Price;
        }

        public void setSale(int n_price)
        {
            this.Is_On_Sale = true;
            this.Price = n_price;
        }

        public bool getSaleState()
        {
            return Is_On_Sale;
        }
    }
}
