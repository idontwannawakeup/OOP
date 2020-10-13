using System;
using System.Collections.Generic;

namespace _06_FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var footballTeams = new List<Team>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                try
                {
                    string command = input.Split(';')[0];

                    string[] info = input.Replace('.', ',').Split(';');
                    Team team = null;
                    foreach (var item in footballTeams)
                        if (item.Name == info[1])
                            team = item;

                    if (team == null && command != "Team")
                        throw new Exception($"Team {info[1]} does not exist.");

                    switch (command)
                    {
                        case "Team":
                            footballTeams.Add(new Team(input.Split(';')[1]));
                            break;
                        case "Add":
                            team.AddPlayer(new Player(info[2],
                                                        double.Parse(info[3]),
                                                        double.Parse(info[4]),
                                                        double.Parse(info[5]),
                                                        double.Parse(info[6]),
                                                        double.Parse(info[7])));
                            break;
                        case "Remove":
                            team.RemovePlayer(info[2]);
                            break;
                        case "Rating":
                            Console.WriteLine($"{team.Name} - {team.Rating}");
                            break;
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }

                input = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
