using System;
using System.Collections.Generic;

namespace _07_SpeedRacing
{
    class Program
    {
        class Car
        {
            public string Model { get; private set; }
            public double FuelAmount { get; private set; }
            public double FuelConsumption { get; private set; }
            public double DistanceTravelled { get; private set; }

            public void Drive(double distance)
            {
                double usedFuel = FuelConsumption * distance;
                if (FuelAmount - usedFuel < 0)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                else
                {
                    FuelAmount -= usedFuel;
                    DistanceTravelled += distance;
                }
            }

            public Car(string model, double fuelAmount, double fuelConsumption)
            {
                Model = model;
                FuelAmount = fuelAmount;
                FuelConsumption = fuelConsumption;
                DistanceTravelled = 0;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carsInRacing = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                carsInRacing.Add(new Car(input[0], double.Parse(input[1]), double.Parse(input[2])));
            }

            string command = Console.ReadLine();
            while (!command.Equals("End"))
            {
                string[] info = command.Split(' ');
                foreach (var car in carsInRacing)
                {
                    if (car.Model.Equals(info[1]))
                    {
                        car.Drive(double.Parse(info[2]));
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
