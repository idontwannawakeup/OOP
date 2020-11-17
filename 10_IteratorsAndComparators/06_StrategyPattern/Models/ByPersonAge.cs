using System;
using System.Collections.Generic;
using System.Text;

namespace _06_StrategyPattern.Models
{
    class ByPersonAge : IComparer<Person>
    {
        public int Compare(Person lhs, Person rhs) => lhs.Age.CompareTo(rhs.Age);
    }
}
