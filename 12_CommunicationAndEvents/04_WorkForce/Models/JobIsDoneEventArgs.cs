using System;
using System.Collections.Generic;
using System.Text;

namespace _04_WorkForce.Models
{
    class JobIsDoneEventArgs : EventArgs
    {
        public string JobName { get; set; }

        public JobIsDoneEventArgs(string jobName)
        {
            JobName = jobName;
        }
    }
}
