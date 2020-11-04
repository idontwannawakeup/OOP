using _02_GenericBoxOfInteger.Models;
using System;
using System.Collections.Generic;

namespace _02_GenericBoxOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var integers = new List<Box<int>>();
            for (int i = 0; i < n; i++)
                integers.Add(new Box<int>(int.Parse(Console.ReadLine())));

            foreach (var item in integers)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
