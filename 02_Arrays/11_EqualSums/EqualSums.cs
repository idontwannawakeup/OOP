using System;

namespace _11_EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = input.Length;

            double[] numbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = double.Parse(input[i].Replace('.', ','));
            }

            int idx = 0;
            bool check = false;
            for (int i = 0; i < n; i++)
            {
                double sumLeft = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    sumLeft += numbers[j];
                }

                double sumRight = 0;
                for (int j = i + 1; j < n; j++)
                {
                    sumRight += numbers[j];
                }

                if (sumLeft == sumRight)
                {
                    check = true;
                    idx = i;
                    break;
                }
            }

            if (check)
            {
                Console.WriteLine(idx);
            }
            else
            {
                Console.WriteLine("no");
            }

            Console.ReadKey();
        }
    }
}
