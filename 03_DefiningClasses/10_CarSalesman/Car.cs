namespace _10_CarSalesman
{
    class Car
    {
        public string Model { get; private set; }
        public Engine CarEngine { get; private set; }
        public int Weight { get; private set; }
        public string Color { get; private set; }

        public override string ToString()
        {
            string strWeight = (Weight == -1) ? "n/a" : $"{Weight}";
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
}
