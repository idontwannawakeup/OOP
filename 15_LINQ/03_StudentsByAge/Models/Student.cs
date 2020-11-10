using System;
using System.Collections.Generic;
using System.Text;

namespace _03_StudentsByAge.Models
{
    class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        public override string ToString() => $"{FirstName} {LastName}";

        public static Student Parse(string input)
        {
            string[] info = input.Split(' ');
            return new Student(info[0], info[1], info[2]);
        }

        public Student(string firstName, string lastName)
            : this(firstName, lastName, 0)
        { }

        public Student(string firstName, string lastName, string age)
            : this(firstName, lastName, int.Parse(age))
        { }

        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
