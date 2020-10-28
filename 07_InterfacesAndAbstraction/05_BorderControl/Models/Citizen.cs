using _05_BorderControl.Interfaces;

namespace _05_BorderControl.Models
{
    class Citizen : IIdentifiable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }

        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
    }
}
