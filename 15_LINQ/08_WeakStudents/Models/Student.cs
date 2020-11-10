using System.Collections.Generic;

namespace _08_WeakStudents.Models
{
    class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public List<double> Marks { get; }

        public override string ToString() => $"{FirstName} {LastName}";

        public static Student Parse(string input)
        {
            string[] info = input.Split(' ');
            var result = new Student(info[0], info[1]);
            for (int i = 2; i < info.Length; i++)
                result.Marks.Add(double.Parse(info[i].Replace('.', ',')));

            return result;
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Marks = new List<double>();
        }
    }
}
