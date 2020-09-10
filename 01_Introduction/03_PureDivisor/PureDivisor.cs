using System;

namespace _03_PureDivisor
{
    class PureDivisor
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool result = (n % 9 == 0) || (n % 11 == 0) || (n % 13 == 0);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
