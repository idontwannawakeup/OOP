using _08_MilitaryElite.Interfaces;

namespace _08_MilitaryElite.Models
{
    class Private : Soldier, IPrivate
    {
        public double Salary { get; set; }

        public override string ToString() => base.ToString() + $" Salary: {Salary:f2}";

        public Private(string id, string firstName, string lastName, string salary)
            : this(int.Parse(id), firstName, lastName,
                   double.Parse(salary.Replace('.',',')))
        { }

        public Private(int id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName)
        {
            Salary = salary;
        }
    }
}
