using System;
using System.Collections.Generic;

namespace _09_RectangleIntersection
{
    class Program
    {
        struct Coordinates
        {
            public int x;
            public int y;

            public Coordinates(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        class Rectangle
        {
            private Coordinates leftTopCorner;

            public string Id { get; }
            public int Width { get; }
            public int Height { get; }
            public Coordinates LeftTopCorner { get => leftTopCorner; }

            public Coordinates CalculateRightBottomCorner()
            {
                return new Coordinates(leftTopCorner.x + Width, leftTopCorner.y - Height);
            }

            public Rectangle(string id, int width, int height, int x, int y)
            {
                Id = id;
                Width = width;
                Height = height;
                leftTopCorner = new Coordinates(x, y);
            }

            public bool CheckIntersection(Rectangle other)
            {
                var thisLeftTop = LeftTopCorner;
                var thisRightBottom = CalculateRightBottomCorner();
                var otherRightBottom = other.CalculateRightBottomCorner();

                // otherRightBottom should be between thisLeftTop and thisRightBottom
                return otherRightBottom.x <= thisRightBottom.x && otherRightBottom.y >= thisRightBottom.y &&
                       otherRightBottom.x >= thisLeftTop.x     && otherRightBottom.y <= thisLeftTop.y;
            }
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            List<Rectangle> rectangles = new List<Rectangle>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ');
                rectangles.Add(new Rectangle(info[0], int.Parse(info[1]), int.Parse(info[2]),
                                             int.Parse(info[3]), int.Parse(info[4])));
            }

            for (int i = 0; i < m; i++)
            {
                string[] info = Console.ReadLine().Split(' ');
                Rectangle lhs = rectangles[0], rhs = rectangles[0];

                foreach (var rectangle in rectangles)
                {
                    if (rectangle.Id.Equals(info[0]))
                    {
                        lhs = rectangle;
                    }

                    if (rectangle.Id.Equals(info[1]))
                    {
                        rhs = rectangle;
                    }
                }

                Console.WriteLine(lhs.CheckIntersection(rhs));
            }

            Console.ReadKey();
        }
    }
}
