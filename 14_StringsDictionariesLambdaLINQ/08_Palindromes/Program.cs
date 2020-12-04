using System;
using System.Linq;

namespace _08_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ' ', ',', '.', '?', '!' };

            string input = Console.ReadLine();
            var words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var sortedPalindroms = words
                .Where(IsPalindrom)
                .OrderBy(e => e)
                .ToArray();

            Console.WriteLine(string.Join(", ", sortedPalindroms));

            Console.ReadKey();
        }

        static bool IsPalindrom(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
                if (str[i] != str[str.Length - 1 - i])
                    return false;

            return true;
        }
    }
}
