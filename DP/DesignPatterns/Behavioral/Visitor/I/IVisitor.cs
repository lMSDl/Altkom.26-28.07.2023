﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.Visitor.I
{
    internal interface IVisitor
    {
        void Visit(PlainText plainText);
        void Visit(BoldText boldText);
        //void Visit(Hyperlink hyperlink);
    }
}
