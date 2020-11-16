using _04_Froggy.Models;
using System;
using System.Linq;

namespace _04_Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();

            var lake = new Lake(numbers);
            Console.WriteLine(string.Join(", ", lake));

            Console.ReadKey();
        }
    }
}
