namespace _06_CompanyRoster
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public Employee(string name, double salary, string position, string department)
            : this(name, salary, position, department, "n/a", -1) { }

        public Employee(string name, double salary, string position, string department, string email)
            : this(name, salary, position, department, email, -1) { }

        public Employee(string name, double salary, string position, string department, int age)
            : this(name, salary, position, department, "n/a", age) { }

        public Employee(string name, double salary, string position,
                        string department, string email, int age)
        {
            Name = name;
            Salary = salary;
            Position = position;
            Department = department;
            Email = email;
            Age = age;
        }
    }
}
