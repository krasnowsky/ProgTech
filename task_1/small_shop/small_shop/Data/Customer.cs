using System;
using System.Collections.Generic;
using System.Text;

namespace small_shop.Data
{
    public class Customer
    {
        private String First_Name;
        private String Last_Name;
        private int Customer_ID;

        public Customer(String name, String lname, int id)
        {
            this.First_Name = name;
            this.Last_Name = lname;
            this.Customer_ID = id;
        }
        public String Get_Customer_Name()
        {
            return this.First_Name;
        }
    }
}
