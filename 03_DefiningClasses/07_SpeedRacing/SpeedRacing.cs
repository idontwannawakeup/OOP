using System;
using System.Collections.Generic;

namespace _07_SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carsInRacing = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                carsInRacing.Add(new Car(input[0], double.Parse(input[1].Replace('.', ',')),
                                                   double.Parse(input[2].Replace('.', ','))));
            }

            string command = Console.ReadLine();
            while (!command.Equals("End"))
            {
                string[] info = command.Split(' ');
                foreach (var car in carsInRacing)
                {
                    if (car.Model.Equals(info[1]))
                    {
                        car.Drive(double.Parse(info[2].Replace('.', ',')));
                        break;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var car in carsInRacing)
            {
                Console.WriteLine($"{car.Model} {string.Format("{0:0.00}", car.FuelAmount)} {car.DistanceTravelled}");
            }

            Console.ReadKey();
        }
    }
}
