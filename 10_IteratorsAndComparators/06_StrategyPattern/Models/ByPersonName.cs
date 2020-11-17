using System;
using System.Collections.Generic;
using System.Text;

namespace _06_StrategyPattern.Models
{
    class ByPersonName : IComparer<Person>
    {
        public int Compare(Person lhs, Person rhs) => lhs.Name.CompareTo(rhs.Name);
    }
}
