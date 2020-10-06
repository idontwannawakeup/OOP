using System.Collections.Generic;

namespace _12_Google
{
    class Pokemons
    {
        public List<Pokemon> Data { get; }

        public void Add(Pokemon newPokemon)
        {
            Data.Add(newPokemon);
        }

        public override string ToString()
        {
            string result = new string("");

            foreach (var item in Data)
                result += item.ToString();

            return result;
        }

        public Pokemons()
        {
            Data = new List<Pokemon>();
        }
    }
}
