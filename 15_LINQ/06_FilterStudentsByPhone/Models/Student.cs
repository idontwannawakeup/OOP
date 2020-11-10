namespace _06_FilterStudentsByPhone.Models
{
    class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Phone { get; }

        public override string ToString() => $"{FirstName} {LastName}";

        public static Student Parse(string input)
        {
            string[] info = input.Split(' ');
            return new Student(info[0], info[1], info[2]);
        }

        public Student(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }
    }
}
