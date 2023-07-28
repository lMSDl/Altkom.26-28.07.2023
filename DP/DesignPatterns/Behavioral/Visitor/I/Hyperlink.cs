﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DP.DesignPatterns.Behavioral.Visitor.I
{
    internal class Hyperlink : IElement
    {
        public string Text { get; set; }
        public string Link { get; set; }

        public void Accept(IVisitor visitor)
        {
            //visitor.Visit(this);
        }
    }
}
