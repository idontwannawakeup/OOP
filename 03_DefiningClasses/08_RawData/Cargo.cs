namespace _08_RawData
{
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
}
