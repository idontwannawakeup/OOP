using System;
using System.Collections.Generic;

namespace _04_OpinionPoll
{
    class Program
    {
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
