using System;
using System.Collections.Generic;

namespace _04_OpinionPoll
{
    class Program
    {
        class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get => name;
                set => name = value;
            }

            public int Age
            {
                get => age;
                set => age = value;
            }

            public Person()
            {
                name = "No name";
                age = 1;
            }

            public Person(int age)
            {
                name = "No name";
                this.age = age;
            }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                persons.Add(new Person(input[0], int.Parse(input[1])));
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(persons[i].Name, persons[j].Name) > 0)
                    {
                        Person tmp = persons[i];
                        persons[i] = persons[j];
                        persons[j] = tmp;
                    }
                }
            }

            foreach (var person in persons)
            {
                if (person.Age > 30)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }

            Console.ReadKey();
        }
    }
}
