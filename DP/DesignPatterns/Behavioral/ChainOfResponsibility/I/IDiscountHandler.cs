﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal interface IDiscountHandler
    {
        bool Discount(float discountValue, float productsPrice);
    }
}
