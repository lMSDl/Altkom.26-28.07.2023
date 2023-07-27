using DP.DesignPatterns.Structural.Adapter.I;
using DP.SOLID.O;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Structural.Bridge.I
{
    internal class Client
    {
        public static void Execute()
        {
            Shape shape = new Square();
            Console.WriteLine(shape);
            Color color = new Red();
            Console.WriteLine(color);

            shape.Color = color;
            Console.WriteLine(shape);

        }
    }
}
