using _06_StrategyPattern.Models;
using System;
using System.Collections.Generic;

namespace _06_StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedByName = new SortedSet<Person>(new ByPersonName());
            var sortedByAge = new SortedSet<Person>(new ByPersonAge());

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var person = Person.Parse(Console.ReadLine());
                sortedByName.Add(person);
                sortedByAge.Add(person);
            }

            Console.WriteLine();
            foreach (var item in sortedByName)
                Console.WriteLine(item);

            foreach (var item in sortedByAge)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
