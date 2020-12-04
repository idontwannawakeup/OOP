using System;

namespace _10_PalindromeIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (!IsPalindrom(input))
            {
                for (int i = 0; i < input.Length; i++)
                {
                    string possiblePalindrom = input.Substring(0, i) + input.Substring(i + 1);
                    if (IsPalindrom(possiblePalindrom))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine(-1);
            }

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
