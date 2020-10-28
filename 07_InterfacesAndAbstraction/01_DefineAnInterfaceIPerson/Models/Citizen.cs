using _01_DefineAnInterfaceIPerson.Interfaces;

namespace _01_DefineAnInterfaceIPerson.Models
{
    class Citizen : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
