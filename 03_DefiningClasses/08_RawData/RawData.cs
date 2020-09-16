using System;
using System.Collections.Generic;

namespace _08_RawData
{
    class Program
    {
        class Engine
        {
            public int Speed { get; private set; }
            public int Power { get; private set; }

            public Engine(int speed, int power)
            {
                Speed = speed;
                Power = power;
            }
        }

        class Cargo
        {
            public int Weight { get; private set; }
            public string Type { get; private set; }

            public Cargo(int weight, string type)
            {
                Weight = weight;
                Type = type;
            }
        }

        class Tire
        {
            public double Pressure { get; private set; }
            public int Age { get; private set; }

            public Tire(double pressure, int age)
            {
                Pressure = pressure;
                Age = age;
            }
        }

        class Car
        {
            public string Model { get; private set; }
            public Engine CarEngine { get; private set; }
            public Cargo CarCargo { get; private set; }
            public Tire[] CarTires { get; private set; }

            public bool IsPressureLessThan(int value)
            {
                foreach (var tire in CarTires)
                {
                    if (tire.Pressure < value)
                    {
                        return true;
                    }
                }
                return false;
            }

            public bool IsEnginePowerGreaterThan(int value)
            {
                return CarEngine.Power > value;
            }

            public Car(string model, int speed, int power, int weight, string type, Tire[] tires)
                : this(model, new Engine(speed, power), new Cargo(weight, type), tires) {}

            public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
            {
                Model = model;
                CarEngine = engine;
                CarCargo = cargo;
                CarTires = tires;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string model = input[0];
                Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                Cargo cargo = new Cargo(int.Parse(input[3]), input[4]);
                Tire[] tires = new Tire[4];
                for (int j = 0, k = 5; j < 4; j++, k += 2)
                {
                    double pressure = double.Parse(input[k].Replace('.', ','));
                    int age = int.Parse(input[k + 1]);
                    tires[j] = new Tire(pressure, age);
                }

                cars.Add(new Car(model, engine, cargo, tires));
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
