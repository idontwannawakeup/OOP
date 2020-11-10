namespace _01_StudentByGroup.Models
{
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Group { get; }

        public override string ToString() => $"{FirstName} {LastName}";

        public static Person Parse(string input)
        {
            string[] info = input.Split(' ');
            return new Person(info[0], info[1], info[2]);
        }

        public Person(string firstName, string lastName)
            : this(firstName, lastName, 0)
        { }

        public Person(string firstName, string lastName, string group)
            : this(firstName, lastName, int.Parse(group))
        { }

        public Person(string firstName, string lastName, int group)
        {
            FirstName = firstName;
            LastName = lastName;
            Group = group;
        }
    }
}
