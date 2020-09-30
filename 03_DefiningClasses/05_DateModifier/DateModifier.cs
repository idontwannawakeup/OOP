using System;

namespace _05_DateModifier
{
    class DateModifier
    {
        private int difference;

        public int Difference { get => difference; }

        public void CalculateDifference(string lhs, string rhs)
        {
            DateTime lhsD = DateTime.Parse(lhs);
            DateTime rhsD = DateTime.Parse(rhs);
            difference = Math.Abs((lhsD - rhsD).Days);
        }
    }
}
