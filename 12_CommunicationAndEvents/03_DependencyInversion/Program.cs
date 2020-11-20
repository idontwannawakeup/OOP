using _03_DependencyInversion.Models;
using System;

namespace _03_DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new PrimitiveCalculator();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] info = input.Split(' ');

                if (info[0] == "mode")
                    calculator.ChangeStrategy(info[1][0]);
                else
                    Console.WriteLine(calculator.PerformCalculation(
                        int.Parse(info[0]),
                        int.Parse(info[1])
                    ));
            }

            Console.ReadKey();
        }
    }
}
