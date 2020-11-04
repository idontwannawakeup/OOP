using _04_GenericSwapMethodIntegers.Models;
using System;
using System.Collections.Generic;

namespace _04_GenericSwapMethodIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var integers = new List<Box<int>>();
            for (int i = 0; i < n; i++)
                integers.Add(new Box<int>(int.Parse(Console.ReadLine())));

            string[] idxs = Console.ReadLine().Split(' ');
            Swap(integers, int.Parse(idxs[0]), int.Parse(idxs[1]));

            foreach (var item in integers)
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
