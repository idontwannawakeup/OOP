using System;
using System.Collections.Generic;

namespace _01_RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                cars.Add(Car.Parse(input));
            }

            string command = Console.ReadLine();
            foreach (var car in cars)
                if (((command.Equals("fragile") && car.IsPressureLessThan(1)) ||
                    (command.Equals("flamable") && car.IsEnginePowerGreaterThan(250))) &&
                    car.CarCargo.Type.Equals(command))
                {
                    Console.WriteLine(car.Model);
                }

            Console.ReadKey();
        }
    }
}
