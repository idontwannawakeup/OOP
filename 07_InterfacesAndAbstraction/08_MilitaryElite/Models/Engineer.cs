using _08_MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace _08_MilitaryElite.Models
{
    class Engineer : SpecialisedSoldier, IEngineer
    {
        public List<Repair> Repairs { get; set; } = new List<Repair>();

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                         .AppendLine("Repairs:");

            foreach (var item in Repairs)
                resultBuilder.AppendLine($"  {item}");

            return resultBuilder.ToString().TrimEnd();
        }

        public Engineer(string id, string firstName, string lastName,
                        string salary, string corps)
            : this(int.Parse(id), firstName, lastName,
                   double.Parse(salary.Replace('.', ',')), corps)
        { }

        public Engineer(int id, string firstName, string lastName,
                        double salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        { }
    }
}
