namespace _11_StudentsJoinedToSpecialties.Models
{
    class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int FacultyNumber { get; }

        public string Name => FirstName + " " + LastName;

        public static Student Parse(string input)
        {
            string[] info = input.Split(' ');
            return new Student(info[1], info[2], info[0]);
        }

        public Student(string firstName,  string lastName, string facultyNumber)
            : this(firstName, lastName, int.Parse(facultyNumber))
        { }

        public Student(string firstName, string lastName, int facultyNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            FacultyNumber = facultyNumber;
        }
    }
}
