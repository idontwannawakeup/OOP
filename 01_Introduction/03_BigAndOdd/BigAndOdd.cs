using System;

namespace _03_BigAndOdd
{
    class BigAndOdd
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool result = (n > 20) && (n % 2 == 1);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
