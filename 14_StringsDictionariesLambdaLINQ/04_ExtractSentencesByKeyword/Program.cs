using System;
using System.Linq;
using System.Text;

namespace _04_ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();

            var lineBuilder = new StringBuilder();
            string input;
            while ((input = Console.ReadLine()) != "end")
                lineBuilder.AppendLine(input);

            string line = lineBuilder.ToString();
            string[] sentences = line.Split('.', '!', '?');
            foreach (var item in sentences)
            {
                var words = item
                    .Split(new string[] { " ", ", ", " - " }, StringSplitOptions.None)
                    .ToList();

                if (words.Contains(keyword))
                    Console.WriteLine(item.Trim());
            }

            Console.ReadKey();
        }
    }
}
