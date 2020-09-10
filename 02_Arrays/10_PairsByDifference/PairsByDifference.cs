using System;

namespace _10_PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = input.Length;
            double difference = double.Parse(Console.ReadLine());

            double[] numbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(input[i]);
            }

            int count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
