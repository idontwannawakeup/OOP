using System;
using System.Linq;
using System.Globalization;

namespace _09_Capitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ' ', '.', ',', '?', '!', ';' };

            string input = Console.ReadLine();
            var words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var capitalizedWords = words.Select(Capitalize).ToArray();

            Console.WriteLine(string.Join(' ', capitalizedWords));

            Console.ReadKey();
        }

        static string Capitalize(string str)
        {
            char capitalizedFirst = char.ToUpper(str[0]);
            string restOfStr = str.Substring(1);
            return capitalizedFirst + restOfStr;
        }
    }
}
