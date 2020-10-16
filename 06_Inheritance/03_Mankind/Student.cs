using System;
using System.Text;

namespace _03_Mankind
{
    class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get => facultyNumber;
            private set
            {
                if (value.Length < 5 || value.Length > 10)
                    throw new ArgumentException("Invalid faculty number!");

                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                         .AppendLine($"Faculty number: {FacultyNumber}");

            return resultBuilder.ToString().TrimEnd();
        }

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }
    }
}
