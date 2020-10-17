using _06_Animals.Interfaces;
using System;
using System.Text;

namespace _06_Animals.Animals
{
    abstract class Animal : ISoundProducable
    {
        private string name;
        private int age;
        private string gender;

        public string Name
        {
            get => name;
            protected set
            {
                if (value == null || value == "")
                    throw new ArgumentException("Invalid input!");

                name = value;
            }
        }

        public int Age
        {
            get => age;
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid input!");

                age = value;
            }
        }

        public string Gender
        {
            get => gender;
            protected set
            {
                if (value == null || value == "" ||
                    (value != "Male" && value != "Female"))
                {
                    throw new ArgumentException("Invalid input!");
                }
                    
                gender = value;
            }
        }

        abstract public string ProduceSound();

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"{GetType().Name}")
                         .AppendLine($"{Name} {Age} {Gender}")
                         .AppendLine(ProduceSound());

            return resultBuilder.ToString().TrimEnd();
        }

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
}
