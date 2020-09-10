using System;

namespace _03_Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;
            Console.WriteLine(area);

            Console.ReadKey();
        }
    }
}
