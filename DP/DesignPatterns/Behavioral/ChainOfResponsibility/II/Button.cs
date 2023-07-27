using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class Button : Component
    {
        public Func<bool> OnClick { get; set; }


        public override void Click()
        {
            if(OnClick())
            {
                return;
            }
            else
            {
                base.Click();
            }
        }
    }
}
