using System;

namespace _06_BirthdayCelebrations
{
    class Citizen : INameable, IIdentifiable, IBirthable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public DateTime Birthdate { get; set; }

        public Citizen(string name, int age, string id, string birthdate)
            : this(name, age, id, DateTime.Parse(birthdate))
        { }

        public Citizen(string name, int age, string id, DateTime birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }
    }
}
