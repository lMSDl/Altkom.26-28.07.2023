﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class Client
    {
        public static void Execute()
        {
            var textBox = new TextBox() { Name = "textBox" };
            var textBoxFrame = new Frame() { Name = "textBoxFrame" };
            textBoxFrame.Add(textBox);

            var button = new Button() { Name = "button" };
            var buttonFrame = new Frame() { Name = "buttonFrame" };
            buttonFrame.Add(button);

            textBox.Add(buttonFrame);

            button.OnClick = () =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                    return false;
                textBox.Text = null;
                return true;
            };


            Console.WriteLine("---");
            textBoxFrame.Click();
            Console.WriteLine("---");
            button.Click();
            Console.WriteLine("---");
            textBox.Click();
            Console.WriteLine("---");
            textBox.Text = "abc";
            Console.WriteLine("---");
            button.Click();
            Console.WriteLine("---");
            button.Click();
        }
    }
}
