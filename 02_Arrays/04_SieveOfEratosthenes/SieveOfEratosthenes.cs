using System;

namespace _04_SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }
            primes[0] = primes[1] = false;

            for (int p = 2; p < n; p++)
            {
                if (primes[p])
                {
                    Console.Write("{0} ", p);
                    for (int i = p; i * p <= n; i++)
                    {
                        primes[i * p] = false;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
