using _03_GenericSwapMethodStrings.Models;
using System;
using System.Collections.Generic;

namespace _03_GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var strings = new List<Box<string>>();
            for (int i = 0; i < n; i++)
                strings.Add(new Box<string>(Console.ReadLine()));

            string[] idxs = Console.ReadLine().Split(' ');
            Swap(strings, int.Parse(idxs[0]), int.Parse(idxs[1]));

            foreach (var item in strings)
                Console.WriteLine(item);

            Console.ReadKey();
        }

        static void Swap<T>(List<T> list, int lhsIdx, int rhsIdx)
        {
            T tmp = list[lhsIdx];
            list[lhsIdx] = list[rhsIdx];
            list[rhsIdx] = tmp;
        }
    }
}
