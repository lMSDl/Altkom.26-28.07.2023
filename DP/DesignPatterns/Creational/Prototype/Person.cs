using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Creational.Prototype
{
    internal class Person : ICloneable
    {
        public Person Parent { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Address Address { get; set; }

        public object Clone()
        {
            var clone = (Person)MemberwiseClone();

            clone.Address = (Address)Address.Clone();
            
            return clone;
        }
    }
}
