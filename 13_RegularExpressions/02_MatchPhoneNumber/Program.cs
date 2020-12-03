using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02_MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^\+| \+)359(\s|-)2\2\d{3}\2\d{4}\b";

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
