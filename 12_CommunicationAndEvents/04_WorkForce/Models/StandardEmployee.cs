using System;
using System.Collections.Generic;
using System.Text;

namespace _04_WorkForce.Models
{
    class StandardEmployee : Employee
    {
        public override int WorkHoursPerWeek { get; } = 40;

        public StandardEmployee(string name)
            : base(name)
        { }
    }
}
