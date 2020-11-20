using System;
using System.Collections.Generic;
using System.Text;

namespace _04_WorkForce.Models
{
    class PartTimeEmployee : Employee
    {
        public override int WorkHoursPerWeek { get; } = 20;

        public PartTimeEmployee(string name)
            : base(name)
        { }
    }
}
