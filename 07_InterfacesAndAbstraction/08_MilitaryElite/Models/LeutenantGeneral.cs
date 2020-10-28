using _08_MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace _08_MilitaryElite.Models
{
    class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public List<IPrivate> Privates { get; set; } = new List<IPrivate>();

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                         .AppendLine("Privates:");

            foreach (var item in Privates)
                resultBuilder.AppendLine($"  {item}");

            return resultBuilder.ToString().TrimEnd();
        }

        public LeutenantGeneral(string id, string firstName, string lastName, string salary)
            : this(int.Parse(id), firstName, lastName,
                   double.Parse(salary.Replace('.',',')))
        { }

        public LeutenantGeneral(int id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName, salary)
        { }
    }
}
