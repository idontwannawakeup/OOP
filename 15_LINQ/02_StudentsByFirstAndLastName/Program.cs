using _02_StudentsByFirstAndLastName.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_StudentsByFirstAndLastName
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

            var filteredStudents = students.Where(
                    element => element.FirstName.CompareTo(element.LastName) < 0
                );

            foreach (var item in filteredStudents)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
