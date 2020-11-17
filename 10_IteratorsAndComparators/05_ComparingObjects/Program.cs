using _05_ComparingObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "END")
                persons.Add(Person.Parse(input));

            int idx = int.Parse(Console.ReadLine());
            var personToMatch = persons[idx - 1];

            int matches = persons.Count(item => item.CompareTo(personToMatch) == 0);
            int notMatches = persons.Count - matches;

            // if matches == 1, it's the Person on idx
            if (matches == 1)
                Console.WriteLine("No matches");
            else
                Console.WriteLine($"{matches} {notMatches} {persons.Count}");

            Console.ReadKey();
        }
    }
}
