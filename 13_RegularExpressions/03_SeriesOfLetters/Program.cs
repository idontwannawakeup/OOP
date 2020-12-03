using System;
using System.Text.RegularExpressions;

namespace _03_SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([a-z])\1+";

            string input = Console.ReadLine();
            var modifiedInput = Regex.Replace(input, pattern, (match) =>
            {
                return match.Groups[1].Value;
            });
            Console.WriteLine(modifiedInput);

            Console.ReadKey();
        }
    }
}
