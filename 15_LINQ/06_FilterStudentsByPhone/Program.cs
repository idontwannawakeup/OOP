using _06_FilterStudentsByPhone.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_FilterStudentsByPhone
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
                    element => element.Phone.StartsWith("02") ||
                               element.Phone.StartsWith("+3592")
                );

            foreach (var item in filteredStudents)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
