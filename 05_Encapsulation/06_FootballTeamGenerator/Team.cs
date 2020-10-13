using System;
using System.Collections.Generic;

namespace _06_FootballTeamGenerator
{
    class Team
    {
        private string name;
        private List<Player> players = new List<Player>();

        public string Name
        {
            get => name;
            private set
            {
                if (value == null || value == "")
                    throw new Exception("A name should not be empty.");

                name = value;
            }
        }

        public double Rating { get => CalculateRating(); }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player playerToDelete = null;
            foreach (var item in players)
                if (item.Name == playerName)
                    playerToDelete = item;

            if (playerToDelete == null)
                throw new Exception($"Player {playerName} is not in {Name} team.");

            players.Remove(playerToDelete);
        }

        private double CalculateRating()
        {
            double result = 0;

            foreach (var item in players)
                result += item.SkillLevel;

            if (players.Count != 0)
                result /= players.Count;

            return Math.Round(result);
        }

        public Team(string name)
        {
            Name = name;
        }
    }
}
