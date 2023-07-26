using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Creational.Builder
{
    internal class Client
    {
        public static void Execute()
        {
            var vehicle = new Vehicle(4, 5, 4, 500, 150);
            Console.WriteLine( vehicle.ToString() );
        
            var builder = new VehicleBuilder();
            builder.SetWeels(4);
            builder.SetSeets(5);
            builder.SetDoors(4);
            builder.SetEngine(150);
            builder.SetTrunk(500);

            vehicle = builder.Build();
            Console.WriteLine(vehicle.ToString());

            vehicle = new VehicleBuilder()
                                .SetWeels(4)
                                .SetSeets(5)
                                .SetDoors(4)
                                .SetEngine(150)
                                .SetTrunk(500)
                                .Build();


            Console.WriteLine(vehicle.ToString());

        }

    }
}
