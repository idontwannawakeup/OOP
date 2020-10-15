using System;
using System.Text;

namespace _01_Person
{
    public class Person
    {
        private string name;
        private int age;

        public virtual string Name
        {
            get => name;
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Name's length should not be" +
                                                " less than 3 symbols!");

                name = value;
            }
        }

        public virtual int Age
        {
            get => age;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age must be positive!");

                age = value;
            }
        }

        public override string ToString() => $"Name: {Name}, Age: {Age}";
        //{
        //    return $"Name: {Name}, Age: {Age}";
        //}

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
