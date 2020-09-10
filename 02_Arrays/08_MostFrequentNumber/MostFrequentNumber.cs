using System;

namespace _08_MostFrequentNumber
{
    class MostFrequentNumber
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

            int mostFrequent = numbers[0], count = 1;
            for (int i = 0; i < n; i++)
            {
                int currentNumber = numbers[i], currentCount = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] == currentNumber)
                    {
                        currentCount++;
                    }
                }

                if (currentCount > count)
                {
                    mostFrequent = currentNumber;
                    count = currentCount;
                }
            }
            Console.WriteLine("{0}", mostFrequent);

            Console.ReadKey();
        }
    }
}
