﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Creational.Builder
{
    internal class Vehicle : ICloneable
    {

        public Vehicle(int wheels, int seats)
        {
            Wheels = wheels;
            Seats = seats;
        }

        public Vehicle(int wheels, int seats, int doors) : this(wheels, seats)
        {
            Doors = doors;
        }

        public Vehicle(int wheels, int seats, int doors, int trunkCapacity) : this(wheels, seats, doors)
        {
            TrunkCapacity = trunkCapacity;
        }

        public Vehicle(int wheels, int seats, int doors, int trunkCapacity, int enginePower) : this(wheels, seats, doors, trunkCapacity)
        {
            EnginePower = enginePower;
        }

        public Vehicle()
        {
        }

        public int Wheels { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        public int? TrunkCapacity { get; set; }
        public int? EnginePower { get; set; }


        public string Manufacturer { get; set; }
        public DateTime ProductionDateTime { get; set; }

        public override string ToString()
        {
            return $"Vehicle has {Wheels} wheels, {Seats} seats, {Doors} doors" + (TrunkCapacity.HasValue ? $", trunk capacity {TrunkCapacity}l" : "") + " and " + (EnginePower.HasValue ? $"engine with {EnginePower}HP" : "no engine");
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
