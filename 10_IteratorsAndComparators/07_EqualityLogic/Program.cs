using _07_EqualityLogic.Models;
using System;
using System.Collections.Generic;

namespace _07_EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedPersons = new SortedSet<Person>();
            var hashPersons = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var person = Person.Parse(Console.ReadLine());
                sortedPersons.Add(person);
                hashPersons.Add(person);
            }

            Console.WriteLine(sortedPersons.Count);
            Console.WriteLine(hashPersons.Count);

            Console.ReadKey();
        }
    }
}
