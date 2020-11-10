namespace _01_StudentByGroup.Models
{
    class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Group { get; }

        public override string ToString() => $"{FirstName} {LastName}";

        public static Student Parse(string input)
        {
            string[] info = input.Split(' ');
            return new Student(info[0], info[1], info[2]);
        }

        public Student(string firstName, string lastName)
            : this(firstName, lastName, 0)
        { }

        public Student(string firstName, string lastName, string group)
            : this(firstName, lastName, int.Parse(group))
        { }

        public Student(string firstName, string lastName, int group)
        {
            FirstName = firstName;
            LastName = lastName;
            Group = group;
        }
    }
}
