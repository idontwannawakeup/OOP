using System;

namespace _07_MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = input.Length;

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            int start = 0, len = 1;
            int bestStart = start, bestLen = len;
            for (int pos = 1; pos < n; pos++)
            {
                if (numbers[pos] > numbers[pos - 1])
                {
                    len++;
                }
                else
                {
                    start = pos;
                    len = 1;
                }

                if (len > bestLen)
                {
                    bestStart = start;
                    bestLen = len;
                }
            }

            for (int i = 0, pos = bestStart; i < bestLen; i++, pos++)
            {
                Console.Write("{0} ", numbers[pos]);
            }

            Console.ReadKey();
        }
    }
}
