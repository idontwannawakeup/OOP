using System;

namespace _03_Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine().Replace('.', ','));
            double b = double.Parse(Console.ReadLine().Replace('.', ','));
            double h = double.Parse(Console.ReadLine().Replace('.', ','));

            double area = ((a + b) / 2) * h;
            Console.WriteLine(area);

            Console.ReadKey();
        }
    }
}
