using System;

namespace _05_CalculateNFactorial
{
    class CalculateNFactorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);

            Console.ReadKey();
        }
    }
}
