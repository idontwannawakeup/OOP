using System;
using System.Collections.Generic;
using System.Text;

namespace _06_StrategyPattern.Models
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"{Name} {Age}";

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
