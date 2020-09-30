namespace _11_PokemonTrainer
{
    class Pokemon
    {
        public string Name { get; }
        public string Element { get; }
        public int Health { get; private set; }

        public void DecreaseHealth(int value)
        {
            Health -= value;
        }

        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }
    }
}
