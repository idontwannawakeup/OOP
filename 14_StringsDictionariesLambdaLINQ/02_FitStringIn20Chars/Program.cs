using System;

namespace _02_FitStringIn20Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = (input.Length > 20)
                ? input.Substring(0, 20)
                : input.PadRight(20, '*');

            Console.WriteLine(input);

            Console.ReadKey();
        }
    }
}
