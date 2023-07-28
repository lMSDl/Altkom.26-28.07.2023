﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DP.DesignPatterns.Behavioral.Visitor.I
{
    internal class HtmlVisitor : IVisitor
    {
        private StringBuilder StringBuilder { get; } = new StringBuilder();

        public void Visit(PlainText plainText)
        {
            StringBuilder.Append(plainText.Text);
        }

        public void Visit(BoldText boldText)
        {
            StringBuilder.Append($"<b>{boldText.Text}</b>");
        }

        public void Visit(Hyperlink hyperlink)
        {
            StringBuilder.Append($"<a href={hyperlink.Link}>{hyperlink.Text}</a>");
        }

        public override string ToString()
        {
            return StringBuilder.ToString();
        }
    }
}
