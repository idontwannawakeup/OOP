using System;

namespace _05_DateModifier
{
    class Program
    {
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
