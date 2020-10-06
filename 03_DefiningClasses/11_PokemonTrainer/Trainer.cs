using System.Collections.Generic;

namespace _11_PokemonTrainer
{
    class Trainer
    {
        public string Name { get; }
        public int BadgesNumber { get; private set; }
        private List<Pokemon> pokemons;

        public int NumberOfPokemon { get => pokemons.Count; }

        public void AddPokemon(Pokemon newPokemon)
        {
            pokemons.Add(newPokemon);
        }

        public void UpdateBadges(string element)
        {
            bool check = false;
            foreach (var pokemon in pokemons)
                if (pokemon.Element.Equals(element))
                {
                    check = true;
                    BadgesNumber++;
                    break;
                }

            if (!check)
            {
                List<Pokemon> pokemonsToRemove = new List<Pokemon>();
                foreach (var pokemon in pokemons)
                {
                    pokemon.DecreaseHealth(10);
                    if (pokemon.Health <= 0)
                        pokemonsToRemove.Add(pokemon);
                }

                foreach (var pokemon in pokemonsToRemove)
                    pokemons.Remove(pokemon);
            }
        }

        public Trainer(string name, Pokemon newPokemon)
        {
            Name = name;
            BadgesNumber = 0;
            pokemons = new List<Pokemon>();
            pokemons.Add(newPokemon);
        }
    }
}
