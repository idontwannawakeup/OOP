using _10_ExplicitInterfaces.Interfaces;

namespace _10_ExplicitInterfaces.Models
{
    class Citizen : IResident, IPerson
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        string IResident.GetName() => $"Mr/Ms/Mrs {Name}";
        string IPerson.GetName() => Name;

        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }
    }
}
