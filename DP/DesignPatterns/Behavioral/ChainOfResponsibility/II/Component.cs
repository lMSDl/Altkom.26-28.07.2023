using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class Component
    {
        public string Name { get; set; }
        public Component Parent { get; set; }

        public virtual void Click()
        {
            Parent?.Click();
        }
    }
}
