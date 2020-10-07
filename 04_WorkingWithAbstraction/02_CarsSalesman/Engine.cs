namespace _02_CarsSalesman
{
    class Engine
    {
        public string Model { get; }
        public int Power { get; }
        public int Displacement { get; }
        public string Efficiency { get; }

        public override string ToString()
        {
            string strDisplacement = (Displacement == -1) ? "n/a" : $"{Displacement}";
            return new string($"{Model}:\n" +
                              $"    Power: {Power}\n" +
                              $"    Displacement: {strDisplacement}\n" +
                              $"    Efficiency: {Efficiency}");
        }

        public static Engine Parse(string input)
        {
            string[] info = input.Split(' ');
            if (info.Length == 2)
            {
                return new Engine(info[0], int.Parse(info[1]));
            }
            else if (info.Length == 3 && int.TryParse(info[2], out int displacement))
            {
                return new Engine(info[0], int.Parse(info[1]), displacement);
            }
            else if (info.Length == 3)
            {
                return new Engine(info[0], int.Parse(info[1]), info[2]);
            }
            else
            {
                return new Engine(info[0], int.Parse(info[1]), int.Parse(info[2]), info[3]);
            }
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
