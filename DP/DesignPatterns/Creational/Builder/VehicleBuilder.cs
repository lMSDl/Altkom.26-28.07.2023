﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Creational.Builder
{
    internal class VehicleBuilder : VehicleBuilderFacade
    {
        public VehicleBuilder()
        {
        }

        internal VehicleBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder SetWeels(int wheels)
        {
            Vehicle.Wheels = wheels;
            return this;
        }

        public VehicleBuilder SetDoors(int doors)
        {
            Vehicle.Doors = doors;
            return this;
        }

        public VehicleBuilder SetEngine(int? power)
        {
            Vehicle.EnginePower = power;
            return this;
        }

        public VehicleBuilder SetTrunk(int? capacity)
        {
            Vehicle.TrunkCapacity = capacity;
            return this;
        }

        public VehicleBuilder SetSeets(int seats)
        {
            Vehicle.Seats = seats;
            return this;
        }


    }
}
