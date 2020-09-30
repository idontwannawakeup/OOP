namespace _12_Google
{
    class Pokemon
    {
        public string Name { get; }
        public string Type { get; }

        public override string ToString()
        {
            return new string($"{Name} {Type}\n");
        }

        public Pokemon(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
