using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Creational.Builder
{
    internal abstract class BuilderBase
    {
        protected Vehicle Vehicle { get; }
        public BuilderBase() : this(new Vehicle())
        {
        }
        public BuilderBase(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return (Vehicle)Vehicle.Clone();
        }
    }
}
