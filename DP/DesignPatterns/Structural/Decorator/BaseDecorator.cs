﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Structural.Decorator
{
    internal abstract class BaseDecorator : INotification
    {
        private INotification _notification;
        public BaseDecorator(INotification notification)
        {
            _notification = notification;
        }

        public void Send(string message)
        {
            _notification.Send(message);
            ExtraSend(message);
        }

        protected abstract void ExtraSend(string message);
    }
}
