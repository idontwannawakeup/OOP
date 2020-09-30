namespace _12_Google
{
    class Company
    {
        public string Name { get; }
        public string Department { get; }
        public double Salary { get; }

        public override string ToString()
        {
            return new string($"{Name} {Department} {string.Format("{0:0.00}", Salary)}\n");
        }

        public Company(string name, string department, double salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }
    }
}
