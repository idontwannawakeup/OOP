using _01_StudentByGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_StudentByGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Person>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                students.Add(Person.Parse(input));
                input = Console.ReadLine();
            }

            var studentsFromGroup2 = students.Where(element => element.Group == 2)
                                             .OrderBy(element => element.FirstName);

            foreach (var item in studentsFromGroup2)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
