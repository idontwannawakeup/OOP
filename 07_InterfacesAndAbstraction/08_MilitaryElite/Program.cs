using _08_MilitaryElite.Interfaces;
using _08_MilitaryElite.Models;
using System;
using System.Collections.Generic;

namespace _08_MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            var soldiers = new List<ISoldier>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                try
                {
                    string[] info = input.Split(' ');
                    soldiers.Add(info[0] switch
                    {
                        "Private"
                            => new Private(info[1], info[2], info[3], info[4]),
                        "LeutenantGeneral"
                            => new LeutenantGeneral(info[1], info[2], info[3], info[4]),
                        "Engineer"
                            => new Engineer(info[1], info[2], info[3], info[4], info[5]),
                        "Commando"
                            => new Commando(info[1], info[2], info[3], info[4], info[5]),
                        "Spy"
                            => new Spy(info[1], info[2], info[3], info[4]),
                        _ => throw new ArgumentException("Invalid soldier type")
                    });

                    if (info[0] == "LeutenantGeneral")
                    {
                        var general = (LeutenantGeneral)soldiers[soldiers.Count - 1];
                        for (int i = 5; i < info.Length; i++)
                        {
                            var id = int.Parse(info[i]);
                            var privateToAdd = soldiers.Find(element => element.Id == id);
                            general.Privates.Add((IPrivate)privateToAdd);
                        }
                    }
                    else if (info[0] == "Engineer")
                    {
                        var lastEngineer = (Engineer)soldiers[soldiers.Count - 1];
                        for (int i = 6; i < info.Length; i += 2)
                        {
                            lastEngineer.Repairs.Add(new Repair(info[i], info[i + 1]));
                        }
                    }
                    else if (info[0] == "Commando")
                    {
                        var commando = (Commando)soldiers[soldiers.Count - 1];
                        for (int i = 6; i < info.Length; i += 2)
                        {
                            try
                            {
                                commando.Missions.Add(new Mission(info[i], info[i + 1]));
                            }
                            catch (ArgumentException) { }
                        }
                    }
                }
                catch (ArgumentException) { }

                input = Console.ReadLine();
            }

            foreach (var item in soldiers)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
