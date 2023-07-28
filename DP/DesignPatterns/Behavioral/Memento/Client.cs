using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Threading.Channels;

namespace DP.DesignPatterns.Behavioral.Memento
{
    internal class Client
    {
        public static void Execute()
        {
            var person = new Person();
            var caretaker = new Caretaker<Person>(person);

            person.FirstName = "Ewa";
            person.LastName = "Ewowska";
            Console.WriteLine(person);
            caretaker.SaveState();

            Thread.Sleep(1500);

            person.FirstName = "Monika";
            Console.WriteLine(person);
            caretaker.SaveState();

            Thread.Sleep(1500);

            person.LastName = "Monikowska";
            Console.WriteLine(person);
            caretaker.SaveState();

            Thread.Sleep(1500);

            person.LastName = null; 
            Console.WriteLine(person);

            caretaker.RestoreState();
            Console.WriteLine(person);

            caretaker.RestoreState(DateTime.Now.AddSeconds(-3));
            Console.WriteLine(person);

        }
    }
}
