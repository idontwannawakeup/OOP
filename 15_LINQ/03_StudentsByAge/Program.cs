using _03_StudentsByAge.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_StudentsByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                students.Add(Student.Parse(input));
                input = Console.ReadLine();
            }

            var filteredStudents
                = students.Where(element => element.Age >= 18 && element.Age <= 24)
                          .Select(element => new {
                              element.FirstName,
                              element.LastName,
                              element.Age
                          });

            foreach (var item in filteredStudents)
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age}");

            Console.ReadKey();
        }
    }
}
