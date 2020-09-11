using System;
using System.Collections.Generic;

namespace _06_CompanyRoster
{
    class Program
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

        class CompanyRoster
        {
            private List<Employee> employees;

            public void AddNewEmployeer(string[] info)
            {
                if (info.Length == 4)
                {
                    employees.Add(new Employee(info[0], double.Parse(info[1]), info[2], info[3]));
                }
                else if (info.Length == 5)
                {
                    if (int.TryParse(info[4], out int age))
                    {
                        employees.Add(new Employee(info[0], double.Parse(info[1]), info[2], info[3], age));
                    }
                    else
                    {
                        employees.Add(new Employee(info[0], double.Parse(info[1]), info[2], info[3], info[4]));
                    }
                }
                else if (info.Length == 6)
                {
                    employees.Add(new Employee(info[0], double.Parse(info[1]), info[2], info[3], info[4], int.Parse(info[5])));
                }
            }

            public string BestDepartment()
            {
                double bestAverage = 0;
                string bestDepartment = "none";

                List<string> departments = new List<string>();
                foreach (var employee in employees)
                {
                    if (!departments.Contains(employee.Department))
                    {
                        departments.Add(employee.Department);
                    }
                }

                foreach (var department in departments)
                {
                    int count = 0;
                    double departmentAverage = 0;
                    foreach (var employee in employees)
                    {
                        if (employee.Department.Equals(department))
                        {
                            count++;
                            departmentAverage += employee.Salary;
                        }
                    }
                    departmentAverage /= count;

                    if (departmentAverage > bestAverage)
                    {
                        bestAverage = departmentAverage;
                        bestDepartment = department;
                    }
                }

                return bestDepartment;
            }

            public List<Employee> EmployeesByDepartment(string department)
            {
                List<Employee> result = new List<Employee>();
                foreach (var employee in employees)
                {
                    if (employee.Department.Equals(department))
                    {
                        result.Add(employee);
                    }
                }
                return result;
            }

            public CompanyRoster()
            {
                employees = new List<Employee>();
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            CompanyRoster company = new CompanyRoster();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                company.AddNewEmployeer(input);
            }

            string bestDepartment = company.BestDepartment();
            var employees = company.EmployeesByDepartment(bestDepartment);
            for (int i = 0; i < employees.Count; i++)
            {
                for (int j = i + 1; j < employees.Count; j++)
                {
                    if (employees[i].Salary < employees[j].Salary)
                    {
                        var tmp = employees[j];
                        employees[j] = employees[i];
                        employees[i] = tmp;
                    }
                }
            }

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.Name} {String.Format("{0:0.00}", item.Salary)} {item.Email} {item.Age}");
            }

            Console.ReadKey();
        }
    }
}
