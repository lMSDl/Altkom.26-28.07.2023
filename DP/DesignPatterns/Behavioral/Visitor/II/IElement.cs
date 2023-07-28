using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.Visitor.II
{
    internal interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
