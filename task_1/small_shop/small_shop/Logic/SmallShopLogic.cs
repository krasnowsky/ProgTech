﻿using System;
using System.Collections.Generic;
using System.Text;
using small_shop;

namespace small_shop.Logic
{
    public class SmallShopLogic
    {
        private Data.SmallShopData data = new Data.SmallShopData();
        public void Create_New_Customer(String fname, String lname, String customer_id)
        {
            Data.Customer new_customer = new Data.Customer(fname, lname, customer_id);
            Data.Cart new_cart = new Data.Cart();

            data.Add_Customer(new_customer, new_cart);
        }
    }
}
