using System;
using System.Collections.Generic;

namespace _11_PokemonTrainer
{
    class Program
    {
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
