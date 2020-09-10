using System;

namespace _05_DateModifier
{
    class Program
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

        static void Main(string[] args)
        {
            string lhs = Console.ReadLine();
            string rhs = Console.ReadLine();

            DateModifier dm = new DateModifier();
            dm.CalculateDifference(lhs, rhs);
            Console.WriteLine(dm.Difference);

            Console.ReadKey();
        }
    }
}
