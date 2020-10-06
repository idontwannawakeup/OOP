using System;
using System.Collections.Generic;

namespace _10_CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ');
                if (info.Length == 2)
                {
                    engines.Add(new Engine(info[0], int.Parse(info[1])));
                }
                else if (info.Length == 3 && int.TryParse(info[2], out int displacement))
                {
                    engines.Add(new Engine(info[0], int.Parse(info[1]), displacement));
                }
                else if (info.Length == 3)
                {
                    engines.Add(new Engine(info[0], int.Parse(info[1]), info[2]));
                }
                else if (info.Length == 4)
                {
                    engines.Add(new Engine(info[0], int.Parse(info[1]), int.Parse(info[2]), info[3]));
                }
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] info = Console.ReadLine().Split(' ');
                string model = info[0];
                Engine newCarEngine = engines[0];
                foreach (var engine in engines)
                    if (engine.Model.Equals(info[1]))
                        newCarEngine = engine;

                if (info.Length == 2)
                {
                    cars.Add(new Car(model, newCarEngine));
                }
                else if (info.Length == 3 && int.TryParse(info[2], out int weight))
                {
                    cars.Add(new Car(model, newCarEngine, weight));
                }
                else if (info.Length == 3)
                {
                    cars.Add(new Car(model, newCarEngine, info[2]));
                }
                else if (info.Length == 4)
                {
                    cars.Add(new Car(model, newCarEngine, int.Parse(info[2]), info[3]));
                }
            }

            foreach (var car in cars)
                Console.WriteLine(car);

            Console.ReadKey();
        }
    }
}
