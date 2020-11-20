using _04_WorkForce.Models;
using System;

namespace _04_WorkForce
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Company();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] info = input.Split(' ');
                string command = info[0];

                switch (command)
                {
                    case "Job":
                        company.AddJob(info[1], int.Parse(info[2]), info[3]);
                        break;
                    case "StandardEmployee":
                        company.AddEmployee(new StandardEmployee(info[1]));
                        break;
                    case "PartTimeEmployee":
                        company.AddEmployee(new PartTimeEmployee(info[1]));
                        break;
                    case "Pass":
                        company.UpdateJobs();
                        break;
                    case "Status":
                        company.PrintJobsStatus();
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
