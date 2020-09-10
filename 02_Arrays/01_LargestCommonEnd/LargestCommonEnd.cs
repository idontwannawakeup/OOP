using System;

namespace _01_LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split(' ');

            string[] shorterArray = firstLine.Length <= secondLine.Length ? firstLine : secondLine;
            string[] longestArray = firstLine.Length > secondLine.Length ? firstLine : secondLine;

            int commonEndLeft = 0;
            for (int i = 0; i < shorterArray.Length; i++)
            {
                if (shorterArray[i] == longestArray[i])
                {
                    commonEndLeft++;
                }
                else
                {
                    break;
                }
            }

            int commonEndRight = 0;
            for (int i = shorterArray.Length - 1, j = longestArray.Length - 1; i >= 0; i--, j--)
            {
                if (shorterArray[i] == longestArray[j])
                {
                    commonEndRight++;
                }
                else
                {
                    break;
                }
            }

            if (commonEndLeft > commonEndRight)
            {
                Console.WriteLine(commonEndLeft);
            }
            else
            {
                Console.WriteLine(commonEndRight);
            }

            Console.ReadKey();
        }
    }
}
