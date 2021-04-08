using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public class Product
    {
        private String Name;
        private String Type;
        private String Production_Date;
        private String Expiration_Date;
        private int price;

        public Product() { }

        public Product(String name, String type, String pro_d, String exp_d)
        {
            this.Name = name;
            this.Type = type;
            this.Production_Date = pro_d;
            this.Expiration_Date = exp_d;
        }

        public String Get_Product_Name()
        {
            return this.Name;
        }
        
        public void setPrice(int price)
        {
            this.price = price;
        }

        public int getPrice()
        {
            return price;
        }
    }
}
