using _10_GroupByGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_GroupByGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                persons.Add(Person.Parse(input));
                input = Console.ReadLine();
            }

            var groupedPersons = persons.GroupBy(element => element.Group)
                                        .OrderBy(element => element.Key);

            foreach (var group in groupedPersons)
                Console.WriteLine($"{group.Key} - {string.Join(", ", group.ToList())}");

            Console.ReadKey();
        }
    }
}
