﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Structural.Decorator
{
    internal class EmailNotification : BaseDecorator
    {
        public EmailNotification(INotification notification) : base(notification)
        {
        }

        protected override void ExtraSend(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }
}
