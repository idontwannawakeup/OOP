using _08_MilitaryElite.Interfaces;
using System.Text;

namespace _08_MilitaryElite.Models
{
    class Spy : Soldier, ISpy
    {
        public int CodeNumber { get; set; }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                         .AppendLine($"Code Number: {CodeNumber}");

            return resultBuilder.ToString().TrimEnd();
        }

        public Spy(string id, string firstName, string lastName, string codeNumber)
            : this(int.Parse(id), firstName, lastName, int.Parse(codeNumber))
        { }

        public Spy(int id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }
    }
}
