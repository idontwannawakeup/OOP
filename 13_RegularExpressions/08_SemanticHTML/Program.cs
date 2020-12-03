using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _08_SemanticHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = $"<div\\s*\\n*(.*?)\\s*\\n*(id|class)\\s*\\n*=\\s*\\n*\"(main|header|nav|article|section|aside|footer)\"\\s*\\n*(.*?)\\s*\\n*>(.*)<\\/div> <!--\\s*\\3\\s*-->";
            var lineBuilder = new StringBuilder();
            string input;
            while ((input = Console.ReadLine()) != "END")
                lineBuilder.AppendLine(input);

            string line = lineBuilder.ToString();
            while (Regex.IsMatch(line, pattern, RegexOptions.Singleline))
            {
                line = Regex.Replace(line, pattern, (match) =>
                {
                    string tag = match.Groups[3].Value;

                    string beforeId = string.IsNullOrWhiteSpace(match.Groups[1].Value)
                        ? string.Empty
                        : $" {match.Groups[1].Value}";

                    string afterId = string.IsNullOrWhiteSpace(match.Groups[4].Value)
                        ? string.Empty
                        : $" {match.Groups[4].Value}";

                    string content = match.Groups[5].Value;

                    return $"<{tag}{beforeId}{afterId}>{content}</{tag}>";
                }, RegexOptions.Singleline);
            }

            Console.WriteLine(line);

            Console.ReadKey();
        }
    }
}
