using _04_SortStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_SortStudents
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

            var sortedStudents = students.OrderBy(element => element.LastName)
                                         .ThenByDescending(element => element.FirstName);

            foreach (var item in sortedStudents)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
