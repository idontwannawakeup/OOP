using System;
using System.Collections.Generic;
using System.Text;

namespace _04_WorkForce.Models
{
    class Company
    {
        private List<Job> jobs = new List<Job>();

        private List<Employee> employees = new List<Employee>();

        public void OnJobIsDone(object sender, JobIsDoneEventArgs e)
        {
            jobs.RemoveAll(element => element.Name == e.JobName);
        }

        public void AddJob(string nameOfJob, int hours, string employeeName)
        {
            var employee = employees.Find(element => element.Name == employeeName);
            var job = new Job(nameOfJob, hours, employee);
            job.JobIsDone += OnJobIsDone;
            jobs.Add(job);
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void PrintJobsStatus()
        {
            foreach (var item in jobs)
                Console.WriteLine(item.Status);
        }

        public void UpdateJobs()
        {
            for (int i = 0; i < jobs.Count; i++)
                jobs[i].Update();
        }
    }
}
