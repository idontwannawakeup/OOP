namespace _08_RawData
{
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
