using _01_GenericBoxOfString.Models;
using System;
using System.Collections.Generic;

namespace _01_GenericBoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var strings = new List<Box<string>>();
            for (int i = 0; i < n; i++)
                strings.Add(new Box<string>(Console.ReadLine()));

            foreach (var item in strings)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
