using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Creational.Prototype
{
    internal class Client
    {
        public static void Execute()
        {
            var p0 = new Person() { Name = "Ewa Ewowska", Age = 45, Address = new Address { City = "Warszawa", Street = "Krakowska" } };

            var p1 = (Person)p0.Clone();
            p1.Name = "Monika Monikowska";
            p1.Parent = p0;

            var p2 = (Person)p0.Clone();
            p2.Name = "Katarzyna Katarzyńska";
            p2.Age = 34;
            p2.Parent = p0;

            Console.WriteLine(JsonSerializer.Serialize(p0));
            Console.WriteLine(JsonSerializer.Serialize(p1));
            Console.WriteLine(JsonSerializer.Serialize(p2));

            p1.Address.Street = "Gdańska";


            Console.WriteLine(JsonSerializer.Serialize(p0));
            Console.WriteLine(JsonSerializer.Serialize(p1));
            Console.WriteLine(JsonSerializer.Serialize(p2));
        }

    }
}
