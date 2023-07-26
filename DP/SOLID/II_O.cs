﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.SOLID.O
{
    abstract class Shape
    {
    }

    class Square : Shape
    {
        public int A { get; set; }
    }

    class Rectangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }
    }

    class Circle : Shape
    {
        public int R { get; set; }
    }

    class ShapeCalculator
    {
        double Area(Shape shape)
        {
            switch (shape)
            {
                case Square square:
                    return square.A * square.A;
                case Rectangle rectangle:
                    return rectangle.A * rectangle.B;
                case Circle circle:
                    return circle.R * circle.R * Math.PI;
                default:
                    return 0;
            }
        }
    }
}
