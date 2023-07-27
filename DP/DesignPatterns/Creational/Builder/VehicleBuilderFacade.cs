using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Creational.Builder
{
    internal class VehicleBuilderFacade : BuilderBase
    {
        public VehicleBuilderFacade()
        {
        }

        internal VehicleBuilderFacade(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder Parts => new VehicleBuilder(Vehicle);
        public VehicleManufactiringBuilder Info => new VehicleManufactiringBuilder(Vehicle);
    }
}
