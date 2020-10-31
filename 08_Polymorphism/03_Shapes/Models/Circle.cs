using System;

namespace _03_Shapes.Models
{
    class Circle : Shape
    {
        private double radius;

        public override double CalculatePerimeter() => 2d * Math.PI * radius;

        public override double CalculateArea() => Math.PI * Math.Pow(radius, 2);

        public override string Draw() => "O";

        public Circle(double radius)
        {
            this.radius = radius;
        }
    }
}
