using System;
using System.Collections.Generic;
using System.Text;

namespace _08_PetClinics.Models
{
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Kind { get; set; }

        public override string ToString() => $"{Name} {Age} {Kind}";

        public Pet(string name, string age, string kind)
            : this(name, int.Parse(age), kind)
        { }

        public Pet(string name, int age, string kind)
        {
            Name = name;
            Age = age;
            Kind = kind;
        }
    }
}
