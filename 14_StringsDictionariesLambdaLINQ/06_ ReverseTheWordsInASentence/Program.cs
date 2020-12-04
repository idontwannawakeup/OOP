using System;
using System.Linq;
using System.Text;

namespace _06__ReverseTheWordsInASentence
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] defaultSeparators =
            {
                '.', ',', ':', ';', '=', '(', ')', '&','[',
                ']', '"', '\'', '\\', '/', '!', '?', ' '
            };
            var noEmptyEntries = StringSplitOptions.RemoveEmptyEntries;

            string input = Console.ReadLine();
            var words = input.Split(defaultSeparators, noEmptyEntries);
            var separators = input.Split(words, noEmptyEntries);
            var reversedWords = words.Reverse().ToArray();

            var sentenceBuilder = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
                sentenceBuilder.Append($"{reversedWords[i]}{separators[i]}");

            string reversedSentence = sentenceBuilder.ToString();
            Console.WriteLine(reversedSentence);

            Console.ReadKey();
        }
    }
}
