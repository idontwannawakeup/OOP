using _05_GenericCountMethodStrings.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_GenericCountMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var strings = new List<Box<string>>();
            for (int i = 0; i < n; i++)
                strings.Add(new Box<string>(Console.ReadLine()));

            string valueToCompare = Console.ReadLine();
            Console.WriteLine(Count(strings, new Box<string>(valueToCompare)));

            Console.ReadKey();
        }

        static int Count<T>(List<T> list, T value)
            where T : IComparable<T>
        {
            return list.Count(element => element.CompareTo(value) > 0);
        }
    }
}
