using _06_BirthdayCelebrations.Interfaces;
using System;

namespace _06_BirthdayCelebrations.Models
{
    class Pet : INameable, IBirthable
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public Pet(string name, string birthdate)
            : this(name, DateTime.Parse(birthdate))
        { }

        public Pet(string name, DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
    }
}
