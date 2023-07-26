using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Creational.FactoryMethod
{
    internal class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var action = "Down";
            var floor = 3;

                elevator.Execute(action, floor);
            elevator.Execute(action, floor);


            elevator.Execute("GoTo", 6);
        }

    }
}
