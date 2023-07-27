using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Structural.Bridge.II
{
    internal class EmailSender : IMessageSenderImplementation
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }
}
