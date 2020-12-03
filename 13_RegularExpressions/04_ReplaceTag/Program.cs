using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _04_ReplaceTag
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "<a href=\"(.*)\">(.*)<\\/a>";

            var lineBuilder = new StringBuilder();
            string input;
            while ((input = Console.ReadLine()) != "end")
                lineBuilder.AppendLine(input);

            var line = lineBuilder.ToString();
            var modifiedLine = Regex.Replace(line, pattern, (match) =>
            {
                return $"[URL href={match.Groups[1].Value}>{match.Groups[2].Value}[/URL]";
            });
            Console.WriteLine(modifiedLine);

            Console.ReadKey();
        }
    }
}
