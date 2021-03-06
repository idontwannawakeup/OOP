﻿using _01_StudentByGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_StudentByGroup
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

            var filteredStudents = students.Where(element => element.Group == 2)
                                           .OrderBy(element => element.FirstName);

            foreach (var item in filteredStudents)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
