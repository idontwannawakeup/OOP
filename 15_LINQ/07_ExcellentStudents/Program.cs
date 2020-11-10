using _07_ExcellentStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_ExcellentStudents
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
                    element => element.Marks.Any(x => x == 6)
                );

            foreach (var item in filteredStudents)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
