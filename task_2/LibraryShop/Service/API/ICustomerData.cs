﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    public interface ICustomerData
    {
        string Name { get; set; }
        int CustomerID { get; set; }
    }
}
