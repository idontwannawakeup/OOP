using System;

namespace _03_LastDigit
{
    class LastDigit
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lastDigit = n % 10;
            Console.WriteLine(lastDigit);

            Console.ReadKey();
        }
    }
}
