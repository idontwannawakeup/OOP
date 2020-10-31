using System;
using System.Text;

namespace _03_Shapes.Models
{
    class Rectangle : Shape
    {
        private double height;
        private double width;

        public override double CalculatePerimeter() => 2d * (height + width);

        public override double CalculateArea() => height * width;

        public override string Draw()
        {
            var resultBuilder = new StringBuilder();

            for (int i = 0; i < height; i++)
            {
                resultBuilder.Append('|');
                char value = (i == 0 || i == height - 1) ? '-' : ' ';
                for (int j = 0; j < width; j++)
                {
                    resultBuilder.Append(value);
                }
                resultBuilder.Append('|' + Environment.NewLine);
            }
            return resultBuilder.ToString();
        }

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
    }
}
