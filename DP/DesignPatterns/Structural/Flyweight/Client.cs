using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Structural.Flyweight
{
    internal class Client
    {
        public static void Execute()
        {
            var factory = new FlyweightFactory(
                new CarFlyweight { Manufacturer = "Chevrolet", Model = "Camaro2018", Color = "Pink" },
                new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C300", Color = "Black" },
                new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C500", Color = "Red" },
                new CarFlyweight { Manufacturer = "BMW", Model = "M5", Color = "Red" },
                new CarFlyweight { Manufacturer = "BMW", Model = "X6", Color = "White" });

            factory.ListFlyweights();

            var car1 = new Car
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Manufacturer = "BMW",
                Model = "M5",
                Color = "Red"
            };
            car1.CarFlyweight = factory.GetFlyweight(car1.CarFlyweight);


            var car2 = new Car
            {
                Number = "CL2213",
                Owner = "Tom Doe",
                Manufacturer = "BMW",
                Model = "M5",
                Color = "Red"
            };
            car2.CarFlyweight = factory.GetFlyweight(car1.CarFlyweight);

            var car3 = new Car
            {
                Number = "CL4127A",
                Owner = "Tom Downton",
                Manufacturer = "BMW",
                Model = "M6",
                Color = "Red"
            };

            car3.CarFlyweight = factory.GetFlyweight(car3.CarFlyweight);


            //car2.Color = "White";

            var colorChange = (CarFlyweight)car2.CarFlyweight.Clone();
            colorChange.Color = "White";
            car2.CarFlyweight = factory.GetFlyweight(colorChange);


            factory.ListFlyweights();
        }
    }
}
