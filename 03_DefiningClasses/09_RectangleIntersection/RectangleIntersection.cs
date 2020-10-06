using System;
using System.Collections.Generic;

namespace _09_RectangleIntersection
{
    class Program
    {
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
                        lhs = rectangle;

                    if (rectangle.Id.Equals(info[1]))
                        rhs = rectangle;
                }

                Console.WriteLine(lhs.CheckIntersection(rhs));
            }

            Console.ReadKey();
        }
    }
}
