using DP.SOLID.O;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Structural.Adapter.I
{
    internal class Client
    {
        public static void Execute()
        {
            ICircle circle = new Circle() { R = 5 };

            circle = new SquareToCircleAdapter(new Square() { A = 8 });

            CheckR(circle);
        }

        public static void CheckR(ICircle circle)
        {
            Console.WriteLine(circle.R <= 5);
        }
    }
}
