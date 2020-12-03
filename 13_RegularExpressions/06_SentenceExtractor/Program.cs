using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _06_SentenceExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentencePattern = @"[\w\s\–’]*[.!?]";
            string wordPattern = @"[\w\–’]*(?=[\s.?!])";

            string keyword = Console.ReadLine();

            var lineBuilder = new StringBuilder();
            string input;
            while ((input = Console.ReadLine()) != "end")
                lineBuilder.Append(input);

            string line = lineBuilder.ToString();
            foreach (Match sentence in Regex.Matches(line, sentencePattern))
            {
                var words = Regex.Matches(sentence.Value, wordPattern)
                    .Select(element => element.Value)
                    .ToList();

                if (words.Contains(keyword))
                    Console.WriteLine(sentence.Value);
            }

            Console.ReadKey();
        }
    }
}
