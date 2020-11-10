using _11_StudentsJoinedToSpecialties.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_StudentsJoinedToSpecialties
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentSpecialties = new List<StudentSpecialty>();
            string input = Console.ReadLine();
            while (input != "Students:")
            {
                studentSpecialties.Add(StudentSpecialty.Parse(input));
                input = Console.ReadLine();
            }

            var students = new List<Student>();
            input = Console.ReadLine();
            while (input != "END")
            {
                students.Add(Student.Parse(input));
                input = Console.ReadLine();
            }

            var joined = students.Join
                (
                    studentSpecialties,
                    s => s.FacultyNumber,
                    st => st.FacultyNumber,
                    (s, st) => new { s.Name, s.FacultyNumber, st.SpecialtyName }
                )
                .OrderBy(element => element.Name);

            foreach (var item in joined)
                Console.WriteLine($"{item.Name} {item.FacultyNumber} {item.SpecialtyName}");

            Console.ReadKey();
        }
    }
}
