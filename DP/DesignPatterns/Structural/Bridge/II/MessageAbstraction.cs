﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Structural.Bridge.II
{
    internal class MessageAbstraction
    {
        public IMessageSenderImplementation MessageSender { get; set; }


        public void Send(string message)
        {
            MessageSender.SendMessage("!!!!" + message.ToUpper() + "!!!!");
        }
    }
}
