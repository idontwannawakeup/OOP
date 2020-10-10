using System;

namespace _01_ClassBox
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine().Replace('.', ','));
            double width = double.Parse(Console.ReadLine().Replace('.', ','));
            double height = double.Parse(Console.ReadLine().Replace('.', ','));

            Box box = new Box(length, width, height);
            Console.WriteLine($"Surface Area – {box.SurfaceArea():0.00}");
            Console.WriteLine($"Lateral Surface Area – {box.LateralSurfaceArea():0.00}");
            Console.WriteLine($"Volume - {box.Volume():0.00}");

            Console.ReadKey();
        }
    }
}
