using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Creational.Prototype
{
    internal class Client
    {
        

        public static void Execute()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            settings.Formatting = Formatting.Indented;

            var p0 = new Person() { Name = "Ewa Ewowska", Age = 45, Address = new Address { City = "Warszawa", Street = "Krakowska" } };

            var p1 = (Person)p0.Clone();
            p1.Name = "Monika Monikowska";
            p1.Parent = p0;

            var p2 = (Person)p0.Clone();
            p2.Name = "Katarzyna Katarzyńska";
            p2.Age = 34;
            p2.Parent = p0;

            Console.WriteLine(JsonConvert.SerializeObject(p0, settings));
            Console.WriteLine(JsonConvert.SerializeObject(p1, settings));
            Console.WriteLine(JsonConvert.SerializeObject(p2, settings));

            p1.Address.Street = "Gdańska";


            Console.WriteLine(JsonConvert.SerializeObject(p0, settings));
            Console.WriteLine(JsonConvert.SerializeObject(p1, settings));
            Console.WriteLine(JsonConvert.SerializeObject(p2, settings));

            p0.Children = new List<Person>() { p1, p2 };

            var p3 = (Person)p0.Clone();
            p3.Name = "Adam Ewowski";

            Console.WriteLine(JsonConvert.SerializeObject(p0, settings));
            Console.WriteLine(JsonConvert.SerializeObject(p3, settings));

            p3.Children.Add(new Person());


            Console.WriteLine(JsonConvert.SerializeObject(p0, settings));
            Console.WriteLine(JsonConvert.SerializeObject(p3, settings));

        }

    }
}
