using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01_MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            var matches = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "end")
                if (Regex.IsMatch(input, pattern))
                    matches.Add(input);

            Console.WriteLine("Matches:");
            foreach (var item in matches)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
