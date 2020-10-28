using _08_MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace _08_MilitaryElite.Models
{
    class Commando : SpecialisedSoldier, ICommando
    {
        public List<Mission> Missions { get; set; } = new List<Mission>();

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                         .AppendLine("Missions:");

            foreach (var item in Missions)
                resultBuilder.AppendLine($"  {item}");

            return resultBuilder.ToString().TrimEnd();
        }

        public Commando(string id, string firstName, string lastName,
                        string salary, string corps)
            : this(int.Parse(id), firstName, lastName,
                   double.Parse(salary.Replace('.',',')), corps)
        { }

        public Commando(int id, string firstName, string lastName,
                        double salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        { }
    }
}
