using System;

namespace _03_NthDigit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int nDigit = ((number / Convert.ToInt32(Math.Pow(10, n - 1))) % 10);
            Console.WriteLine(nDigit);

            Console.ReadKey();
        }
    }
}
