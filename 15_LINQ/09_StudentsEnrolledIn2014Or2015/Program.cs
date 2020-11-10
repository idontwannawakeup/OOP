using _09_StudentsEnrolledIn2014Or2015.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_StudentsEnrolledIn2014Or2015
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
                    element => element.FacultyNumber.Substring(4, 2) == "14" ||
                               element.FacultyNumber.Substring(4, 2) == "15"
                );

            foreach (var item in filteredStudents)
                Console.WriteLine(string.Join(' ', item.Marks));

            Console.ReadKey();
        }
    }
}
