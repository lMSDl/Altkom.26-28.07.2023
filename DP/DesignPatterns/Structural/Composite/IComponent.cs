﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Structural.Composite
{
    internal interface IComponent
    {
        string Name { get; }
        float GetValue();
    }
}
