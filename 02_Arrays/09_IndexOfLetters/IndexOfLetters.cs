using System;

namespace _09_IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
                                'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                                's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
                              };
            string word = Console.ReadLine();

            foreach (char character in word)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (character == alphabet[i])
                    {
                        Console.WriteLine("{0} -> {1}", character, i);
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
