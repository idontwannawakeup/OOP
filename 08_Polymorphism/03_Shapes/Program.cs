using _03_Shapes.Models;
using System;

namespace _03_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape rc = new Rectangle(3, 4);
            Shape cr = new Circle(3);

            Console.WriteLine($"Rectangle's perimeter: {rc.CalculatePerimeter():f2}");
            Console.WriteLine($"Rectangle's area: {rc.CalculateArea():f2}");
            Console.WriteLine(rc.Draw());

            Console.WriteLine($"Circle's perimeter: {cr.CalculatePerimeter():f2}");
            Console.WriteLine($"Circle's area: {cr.CalculateArea():f2}");
            Console.WriteLine(cr.Draw());

            Console.ReadKey();
        }
    }
}
