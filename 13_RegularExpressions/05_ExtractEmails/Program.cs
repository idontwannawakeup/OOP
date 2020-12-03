using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _05_ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailPattern =
                @"\b(?<![-._])[a-zA-Z0-9]+[-._]?[a-zA-Z0-9]+(?!=[-._])\b@\b(?<![-._])[\w-]+\.[\w-.]+\b";

            var lineBuilder = new StringBuilder();
            string input;
            while ((input = Console.ReadLine()) != "end")
                lineBuilder.AppendLine(input);

            string line = lineBuilder.ToString();
            foreach (Match item in Regex.Matches(line, emailPattern))
                Console.WriteLine(item.Value);

            Console.ReadKey();
        }
    }
}
