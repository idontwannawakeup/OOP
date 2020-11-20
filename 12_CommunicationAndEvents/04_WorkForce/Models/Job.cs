using System;
using System.Collections.Generic;
using System.Text;

namespace _04_WorkForce.Models
{
    class Job
    {
        public event EventHandler<JobIsDoneEventArgs> JobIsDone;

        private Employee employee;

        public string Name { get; set; }

        public int HoursOfWorkRequired { get; set; }

        public void Update()
        {
            HoursOfWorkRequired -= employee.WorkHoursPerWeek;

            if (HoursOfWorkRequired <= 0)
            {
                Console.WriteLine($"Job {Name} done!");
                JobIsDone?.Invoke(this, new JobIsDoneEventArgs(Name));
            }
        }

        public string Status => $"Job: {Name} Hours Remaining: {HoursOfWorkRequired}";

        public Job(string name, int hoursOfWorkRequired, Employee employee)
        {
            Name = name;
            HoursOfWorkRequired = hoursOfWorkRequired;
            this.employee = employee;
        }
    }
}
