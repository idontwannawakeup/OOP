namespace _10_CarSalesman
{
    class Engine
    {
        public string Model { get; private set; }
        public int Power { get; private set; }
        public int Displacement { get; private set; }
        public string Efficiency { get; private set; }

        public override string ToString()
        {
            string strDisplacement = (Displacement == -1) ? "n/a" : $"{Displacement}";
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
}
