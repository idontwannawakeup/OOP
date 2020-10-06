using System;
using System.Collections.Generic;

namespace _08_RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                Cargo cargo = new Cargo(int.Parse(input[3]), input[4]);
                Tire[] tires = new Tire[4];
                for (int j = 0, k = 5; j < 4; j++, k += 2)
                {
                    tires[j] = new Tire(double.Parse(input[k].Replace('.', ',')),
                                        int.Parse(input[k + 1]));
                }

                cars.Add(new Car(input[0], engine, cargo, tires));
            }

            string command = Console.ReadLine();
            switch (command)
            {
                case "fragile":
                    foreach (var car in cars)
                    {
                        if (car.CarCargo.Type.Equals(command) && car.IsPressureLessThan(1))
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                    break;
                case "flamable":
                    foreach (var car in cars)
                    {
                        if (car.CarCargo.Type.Equals(command) && car.IsEnginePowerGreaterThan(250))
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}
