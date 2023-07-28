﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.Strategy
{
    internal class MultiplyStrategy : ICalcStrategy
    {
        public float Calc(float a, float b)
        {
            return a * b;
        }
    }
}