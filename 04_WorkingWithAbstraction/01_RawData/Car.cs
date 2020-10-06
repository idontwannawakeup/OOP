namespace _01_RawData
{
    class Car
    {
        public string Model { get; }
        public Engine CarEngine { get; }
        public Cargo CarCargo { get; }
        public Tire[] CarTires { get; }

        public bool IsPressureLessThan(int value)
        {
            foreach (var tire in CarTires)
                if (tire.Pressure < value)
                    return true;

            return false;
        }

        public bool IsEnginePowerGreaterThan(int value)
        {
            return CarEngine.Power > value;
        }

        public static Car Parse(string input)
        {
            string[] info = input.Split(' ');
            Tire[] tires = new Tire[4];
            for (int i = 0, j = 5; i < 4; i++, j += 2)
            {
                tires[i] = new Tire(double.Parse(info[j].Replace('.', ',')),
                                    int.Parse(info[j + 1]));
            }

            return new Car(info[0],
                           new Engine(int.Parse(info[1]), int.Parse(info[2])),
                           new Cargo(int.Parse(info[3]), info[4]),
                           tires);
        }

        public Car(string model, int speed, int power, int weight, string type, Tire[] tires)
            : this(model, new Engine(speed, power), new Cargo(weight, type), tires) { }

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            Model = model;
            CarEngine = engine;
            CarCargo = cargo;
            CarTires = tires;
        }
    }
}
