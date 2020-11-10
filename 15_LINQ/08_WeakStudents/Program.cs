using _08_WeakStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_WeakStudents
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
                    element => element.Marks.Count(x => x <= 3) >= 2
                );

            foreach (var item in filteredStudents)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
