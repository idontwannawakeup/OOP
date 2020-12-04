using System;
using System.Linq;

namespace _01_ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversed = new string(input.ToCharArray().Reverse().ToArray());
            Console.WriteLine(reversed);

            Console.ReadKey();
        }
    }
}
