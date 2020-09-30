using System.Collections.Generic;

namespace _06_CompanyRoster
{
    class Company
    {
        private List<Employee> employees;

        public void AddNewEmployeer(string[] info)
        {
            if (info.Length == 4)
            {
                employees.Add(new Employee(info[0], double.Parse(info[1].Replace('.', ',')),
                              info[2], info[3]));
            }
            else if (info.Length == 5)
            {
                if (int.TryParse(info[4], out int age))
                {
                    employees.Add(new Employee(info[0], double.Parse(info[1].Replace('.', ',')),
                                  info[2], info[3], age));
                }
                else
                {
                    employees.Add(new Employee(info[0], double.Parse(info[1].Replace('.', ',')),
                                  info[2], info[3], info[4]));
                }
            }
            else if (info.Length == 6)
            {
                employees.Add(new Employee(info[0], double.Parse(info[1].Replace('.', ',')),
                              info[2], info[3], info[4], int.Parse(info[5])));
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

        public Company()
        {
            employees = new List<Employee>();
        }
    }
}
