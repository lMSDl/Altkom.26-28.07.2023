namespace DP.SOLID.O
{
    abstract class Shape
    {
        public abstract double Area { get; }
    }

    class Square : Shape
    {
        public int A { get; set; }

        public override double Area => A * A;
    }

    class Rectangle : Shape
    {
        public int A { get; set; }
        public int B { get; set; }

        public override double Area => A * B;
    }

    class Circle : Shape
    {
        public int R { get; set; }

        public override double Area => R * R * Math.PI;
    }

    class ShapeCalculator
    {
        double Area(Shape shape)
        {
            return shape.Area;
        }
    }

    /*abstract class Shape
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
    }*/
}
