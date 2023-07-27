using DP.DesignPatterns.Structural.Adapter.I;
using DP.DesignPatterns.Structural.Bridge.I;
using DP.SOLID.O;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Structural.Bridge.II
{
    internal class Client
    {
        public static void Execute()
        {
            var abstraction = new MessageAbstraction();

            abstraction.MessageSender = new SmsSender();
            abstraction.Send(Console.ReadLine());


            abstraction.MessageSender = new EmailSender();
            abstraction.Send(Console.ReadLine());
        }
    }
}
