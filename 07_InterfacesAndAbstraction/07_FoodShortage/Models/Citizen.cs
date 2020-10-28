using _07_FoodShortage.Interfaces;
using System;

namespace _07_FoodShortage.Models
{
    class Citizen : INameableBuyer, IIdentifiable, IBirthable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public DateTime Birthdate { get; set; }
        public int Food { get; set; }

        public void BuyFood() { Food += 10; }

        public Citizen(string name, int age, string id, string birthdate)
            : this(name, age, id, DateTime.Parse(birthdate))
        { }

        public Citizen(string name, int age, string id, DateTime birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
            Food = 0;
        }
    }
}
