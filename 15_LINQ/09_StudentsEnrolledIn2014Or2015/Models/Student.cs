using System.Collections.Generic;

namespace _09_StudentsEnrolledIn2014Or2015.Models
{
    class Student
    {
        public string FacultyNumber { get; }
        public List<double> Marks { get; }

        public static Student Parse(string input)
        {
            string[] info = input.Split(' ');
            var result = new Student(info[0]);
            for (int i = 1; i < info.Length; i++)
                result.Marks.Add(double.Parse(info[i].Replace('.', ',')));

            return result;
        }

        public Student(string facultyNumber)
        {
            FacultyNumber = facultyNumber;
            Marks = new List<double>();
        }
    }
}
