using _06_GenericCountMethodDoubles.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_GenericCountMethodDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var doubles = new List<Box<double>>();
            for (int i = 0; i < n; i++)
            {
                var value = double.Parse(Console.ReadLine().Replace('.', ','));
                doubles.Add(new Box<double>(value));
            }

            double valueToCompare = double.Parse(Console.ReadLine().Replace('.', ','));
            Console.WriteLine(Count(doubles, new Box<double>(valueToCompare)));

            Console.ReadKey();
        }

        static int Count<T>(List<T> list, T value)
            where T : IComparable<T>
        {
            return list.Count(element => element.CompareTo(value) > 0);
        }
    }
}
