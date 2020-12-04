using System;
using System.Text.RegularExpressions;

namespace _07_ChangeToUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            string uppercasePattern = @"<upcase>(.*?)<\/upcase>";

            string input = Console.ReadLine();
            while (Regex.IsMatch(input, uppercasePattern))
            {
                input = Regex.Replace(input, uppercasePattern, (match) =>
                {
                    return match.Groups[1].Value.ToUpper();
                });
            }

            Console.WriteLine(input);

            Console.ReadKey();
        }
    }
}
