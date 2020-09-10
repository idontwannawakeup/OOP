using System;

namespace _03_FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = input.Length;
            int k = n / 4;
            int nRows = k * 2;

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            int[] firstRow = new int[nRows];
            for (int i = 0, j = n - 1; i < k; i++, j--)
            {
                // Заповнюю першу половину firstRow оберненими числами з початку numbers
                firstRow[i] = numbers[(k - 1) - i];
                // Заповнюю другу половину firstRow оберненими числами з кінця numbers
                firstRow[i + k] = numbers[j];
            }

            int[] secondRow = new int[nRows];
            for (int i = 0; i < nRows; i++)
            {
                // Заповнюю secondRow числами з середини numbers
                secondRow[i] = numbers[i + k];
            }

            for (int i = 0; i < nRows; i++)
            {
                int sum = firstRow[i] + secondRow[i];
                Console.Write("{0} ", sum);
            }

            Console.ReadKey();
        }
    }
}
