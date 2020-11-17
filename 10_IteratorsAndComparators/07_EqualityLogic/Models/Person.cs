using System;
using System.Collections.Generic;
using System.Text;

namespace _07_EqualityLogic.Models
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (Name != other.Name)
                return Name.CompareTo(other.Name);
            else
                return Age.CompareTo(other.Age);
        }

        public override string ToString() => $"{Name} {Age}";

        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;

            return Name == ((Person)obj).Name && Age == ((Person)obj).Age;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + (Age.GetHashCode() * 2);
        }

        public static Person Parse(string input)
        {
            string[] info = input.Split(' ');
            return new Person(info[0], info[1]);
        }

        public Person(string name, string age)
            : this(name, int.Parse(age))
        { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
