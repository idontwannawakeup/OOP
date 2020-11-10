using _05_FilterStudentsByEmailDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_FilterStudentsByEmailDomain
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
                    element => element.Email.EndsWith("@gmail.com")
                );

            foreach (var item in filteredStudents)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
