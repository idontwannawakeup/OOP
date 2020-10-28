using _03_Ferrari.Models;
using System;

namespace _03_Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            string driver = Console.ReadLine();
            var car = new Ferrari(driver);

            Console.WriteLine($"{car.Model}/{car.UseBrakes()}/" +
                              $"{car.PushGasPedal()}/{car.Driver}");

            Console.ReadKey();
        }
    }
}
