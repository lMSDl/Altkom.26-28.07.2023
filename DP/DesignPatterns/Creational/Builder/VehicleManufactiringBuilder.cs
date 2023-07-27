using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Creational.Builder
{
    internal class VehicleManufactiringBuilder : VehicleBuilderFacade
    {
        public VehicleManufactiringBuilder()
        {
        }

        internal VehicleManufactiringBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleManufactiringBuilder SetProductionDateTime(DateTime value)
        {
            Vehicle.ProductionDateTime = value;
            return this;
        }
        public VehicleManufactiringBuilder SetManufacturer(string value)
        {
            Vehicle.Manufacturer = value;
            return this;
        }


    }
}
