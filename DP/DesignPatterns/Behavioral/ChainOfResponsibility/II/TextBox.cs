﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class TextBox : Container
    {
        private string text;
        public string Text
        {
            get => text;
            set
            {
                text = value;
                Console.WriteLine($"{Name} zmienił wartość na {value}");
            }
        }


        protected override void Click(bool handled)
        {
            if (handled)
                base.Click(handled);
            else
            {
                Console.WriteLine($"{Name} złapał focus");
                base.Click(true);
            }
        }
    }
}
