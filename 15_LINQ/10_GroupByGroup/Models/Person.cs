namespace _10_GroupByGroup.Models
{
    class Person
    {
        public string Name { get; }
        public int Group { get; }

        public override string ToString() => Name;

        public static Person Parse(string input)
        {
            string[] info = input.Split(' ');
            return new Person(info[0] + " " + info[1], info[2]);
        }

        public Person(string name, string group)
            : this(name, int.Parse(group))
        { }

        public Person(string name, int group)
        {
            Name = name;
            Group = group;
        }
    }
}
