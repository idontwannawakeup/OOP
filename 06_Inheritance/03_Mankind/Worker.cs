using System;
using System.Text;

namespace _03_Mankind
{
    class Worker : Human
    {
        private double weekSalary;
        private int workingHours;

        public double WeekSalary
        {
            get => weekSalary;
            private set
            {
                if (value < 10)
                    throw new ArgumentException("Expected value mismatch! " +
                                                "Argument: weekSalary");

                weekSalary = value;
            }
        }

        public int WorkingHours
        {
            get => workingHours;
            private set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Expected value mismatch! " +
                                                "Argument: workHoursPerDay");

                workingHours = value;
            }
        }

        public double SalaryPerHour { get => CalculateSalaryPerHour(); }

        private double CalculateSalaryPerHour() => WeekSalary / (workingHours * 5.0);

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                         .AppendLine($"Week Salary: {WeekSalary:f2}")
                         .AppendLine($"Hours per day: {WorkingHours:f2}")
                         .AppendLine($"Salary per hour: {SalaryPerHour:f2}");

            return resultBuilder.ToString().TrimEnd();
        }

        public Worker(string firstName, string lastName,
                      double weekSalary, int workingHours) : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkingHours = workingHours;
        }
    }
}
