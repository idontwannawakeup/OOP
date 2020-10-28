using _08_MilitaryElite.Interfaces;
using System;
using System.Text;

namespace _08_MilitaryElite.Models
{
    class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;

        public string Corps
        {
            get => corps;
            set
            {
                if (value != "Airforces" && value != "Marines")
                    throw new ArgumentException("Wrong corps!");

                corps = value;
            }
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                         .AppendLine($"Corps: {Corps}");

            return resultBuilder.ToString().TrimEnd();
        }

        public SpecialisedSoldier(string id, string firstName, string lastName,
                                  string salary, string corps)
            : this(int.Parse(id), firstName, lastName,
                   double.Parse(salary.Replace('.', ',')), corps)
        { }

        public SpecialisedSoldier(int id, string firstName, string lastName,
                                  double salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }
    }
}
