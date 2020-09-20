using System;
using System.Collections.Generic;

namespace _11_PokemonTrainer
{
    class Program
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
                {
                    if (pokemon.Element.Equals(element))
                    {
                        check = true;
                        BadgesNumber++;
                        break;
                    }
                }

                if (!check)
                {
                    List<Pokemon> pokemonsToRemove = new List<Pokemon>();
                    foreach (var pokemon in pokemons)
                    {
                        pokemon.DecreaseHealth(10);
                        if (pokemon.Health <= 0)
                        {
                            pokemonsToRemove.Add(pokemon);
                        }
                    }

                    foreach (var pokemon in pokemonsToRemove)
                    {
                        pokemons.Remove(pokemon);
                    }
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

        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            string command = Console.ReadLine();
            while (!command.Equals("Tournament"))
            {
                string[] info = command.Split(' ');
                string trainerName = info[0];
                bool check = false;
                Pokemon newPokemon = new Pokemon(info[1], info[2], int.Parse(info[3]));

                foreach (var trainer in trainers)
                {
                    if (trainer.Name.Equals(trainerName))
                    {
                        trainer.AddPokemon(newPokemon);
                        check = true;
                        break;
                    }
                }

                if (!check)
                {
                    trainers.Add(new Trainer(trainerName, newPokemon));
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while(!command.Equals("End"))
            {
                string element = command;
                foreach (var trainer in trainers)
                {
                    trainer.UpdateBadges(element);
                }
                command = Console.ReadLine();
            }

            for (int i = 0; i < trainers.Count; i++)
            {
                for (int j = i + 1; j < trainers.Count; j++)
                {
                    if (trainers[i].BadgesNumber < trainers[j].BadgesNumber)
                    {
                        var tmp = trainers[i];
                        trainers[i] = trainers[j];
                        trainers[j] = tmp;
                    }
                }
            }

            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.BadgesNumber} {trainer.NumberOfPokemon}");
            }

            Console.ReadKey();
        }
    }
}
