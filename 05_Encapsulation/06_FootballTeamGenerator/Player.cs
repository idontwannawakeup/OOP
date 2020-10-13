using System;

namespace _06_FootballTeamGenerator
{
    class Player
    {
        private string name;
        private double endurance;
        private double sprint;
        private double dribble;
        private double passing;
        private double shooting;

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

        public double Endurance
        {
            get => endurance;
            private set => SetDoubleField(ref endurance, value);
        }

        public double Sprint
        {
            get => sprint;
            private set => SetDoubleField(ref sprint, value);
        }

        public double Dribble
        {
            get => dribble;
            private set => SetDoubleField(ref dribble, value);
        }

        public double Passing
        {
            get => passing;
            private set => SetDoubleField(ref passing, value);
        }

        public double Shooting
        {
            get => shooting;
            private set => SetDoubleField(ref shooting, value);
        }

        public double SkillLevel { get => CalculateSkillLevel(); }

        private double CalculateSkillLevel()
        {
            return (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;
        }

        private void SetDoubleField(ref double field, double value)
        {
            if (value < 0 || value > 100)
                throw new Exception($"{char.ToUpper(nameof(field)[0])}" +
                                    $"{nameof(field).Substring(1)} "    +
                                    $"should be between 0 and 100.");

            field = value;
        }

        public Player(string name, double endurance, double sprint,
                      double dribble, double passing, double shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }
    }
}
