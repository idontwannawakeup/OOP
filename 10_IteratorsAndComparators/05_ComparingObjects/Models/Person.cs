using System;

namespace _05_ComparingObjects.Models
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            if (Name.CompareTo(other.Name) != 0)
                return Name.CompareTo(other.Name);
            else if (Age.CompareTo(other.Age) != 0)
                return Age.CompareTo(other.Age);
            else
                return Town.CompareTo(other.Town);
        }

        public static Person Parse(string input)
        {
            string[] info = input.Split(' ');
            return new Person(info[0], info[1], info[2]);
        }

        public Person(string name, string age, string town)
            : this(name, int.Parse(age), town)
        { }

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }
    }
}
