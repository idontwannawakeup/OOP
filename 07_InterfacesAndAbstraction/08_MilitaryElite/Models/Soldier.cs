using _08_MilitaryElite.Interfaces;

namespace _08_MilitaryElite.Models
{
    class Soldier : ISoldier
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"Name: {FirstName} {LastName} Id: {Id}";

        public Soldier(string id, string firstName, string lastName)
            : this (int.Parse(id), firstName, lastName)
        { }

        public Soldier(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
