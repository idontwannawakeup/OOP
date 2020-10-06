using System;

namespace _06_CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Company company = new Company();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                company.AddNewEmployeer(input);
            }

            string bestDepartment = company.BestDepartment();
            var employees = company.EmployeesByDepartment(bestDepartment);
            for (int i = 0; i < employees.Count; i++)
                for (int j = i + 1; j < employees.Count; j++)
                    if (employees[i].Salary < employees[j].Salary)
                    {
                        var tmp = employees[j];
                        employees[j] = employees[i];
                        employees[i] = tmp;
                    }

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");
            foreach (var item in employees)
                Console.WriteLine($"{item.Name} {item.Salary:0.00} {item.Email} {item.Age}");

            Console.ReadKey();
        }
    }
}
