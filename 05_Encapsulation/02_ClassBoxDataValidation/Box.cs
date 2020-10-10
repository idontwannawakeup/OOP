using System;

namespace _02_ClassBoxDataValidation
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        private double Length
        {
            set
            {
                if (value <= 0)
                    throw new Exception("Length cannot be zero or negative.");

                length = value;
            }
        }

        private double Width
        {
            set
            {
                if (value <= 0)
                    throw new Exception("Width cannot be zero or negative.");

                width = value;
            }
        }

        private double Height
        {
            set
            {
                if (value <= 0)
                    throw new Exception("Height cannot be zero or negative.");

                height = value;
            }
        }

        public double SurfaceArea()
        {
            return 2 * length * width +
                   2 * length * height +
                   2 * width * height;
        }

        public double LateralSurfaceArea()
        {
            return 2 * length * height +
                   2 * width * height;
        }

        public double Volume()
        {
            return length * width * height;
        }

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
    }
}
