namespace _02_StudentsByFirstAndLastName.Models
{
    class Student
    {
        public string FirstName { get; }
        public string LastName { get; }

        public override string ToString() => $"{FirstName} {LastName}";

        public static Student Parse(string input)
        {
            string[] info = input.Split(' ');
            return new Student(info[0], info[1]);
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
