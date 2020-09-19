using System;
using System.Collections.Generic;

namespace _10_CarSalesman
{
    class Program
    {
        class Engine
        {
            public string Model { get; private set; }
            public int Power { get; private set; }
            public int Displacement { get; private set; }
            public string Efficiency { get; private set; }

            public override string ToString()
            {
                string strDisplacement = Displacement == -1 ? "n/a" : $"{Displacement}";
                return new string($"{Model}:\n" +
                                  $"    Power: {Power}\n" +
                                  $"    Displacement: {strDisplacement}\n" +
                                  $"    Efficiency: {Efficiency}");
            }

            public Engine(string model, int power)
                : this(model, power, -1, "n/a") { }

            public Engine(string model, int power, int displacement)
                : this(model, power, displacement, "n/a") { }

            public Engine(string model, int power, string efficiency)
                : this(model, power, -1, efficiency) { }

            public Engine(string model, int power, int displacement, string efficiency)
            {
                Model = model;
                Power = power;
                Displacement = displacement;
                Efficiency = efficiency;
            }
        }

        class Car
        {
            public string Model { get; private set; }
            public Engine CarEngine { get; private set; }
            public int Weight { get; private set; }
            public string Color { get; private set; }

            public override string ToString()
            {
                string strWeight = Weight == -1 ? "n/a" : $"{Weight}";
                return new string($"{Model}:\n" +
                                  $"  {CarEngine}\n" +
                                  $"  Weight: {strWeight}\n" +
                                  $"  Color: {Color}");
            }

            public Car(string model, Engine engine)
                : this(model, engine, -1, "n/a") { }

            public Car(string model, Engine engine, int weight)
                : this(model, engine, weight, "n/a") { }

            public Car(string model, Engine engine, string color)
                : this(model, engine, -1, color) { }

            public Car(string model, Engine engine, int weight, string color)
            {
                Model = model;
                CarEngine = engine;
                Weight = weight;
                Color = color;
            }
        }

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
                {
                    if (engine.Model.Equals(info[1]))
                    {
                        newCarEngine = engine;
                    }
                }

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
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
