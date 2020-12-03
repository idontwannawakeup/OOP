using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07_ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string usernamePattern = @"\b[a-zA-z]\w{2,24}\b";

                string input = Console.ReadLine();
                if (input.Length > 9999)
                    throw new Exception("Invalid input length");

                var usernames = input
                    .Split(' ', '/', '\\', '(', ')')
                    .ToList();

                var validUsernames = usernames
                    .Where(element => Regex.IsMatch(element, usernamePattern))
                    .ToList();

                string maxLhs = (validUsernames.Count == 1)
                    ? validUsernames[0]
                    : string.Empty;

                string maxRhs = string.Empty;

                for (int i = 0; i < validUsernames.Count - 1; i++)
                    if ((maxLhs.Length + maxRhs.Length) <
                        (validUsernames[i].Length + validUsernames[i + 1].Length))
                    {
                        maxLhs = validUsernames[i];
                        maxRhs = validUsernames[i + 1];
                    }

                Console.WriteLine(maxLhs);
                Console.WriteLine(maxRhs);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }

            Console.ReadKey();
        }
    }
}
