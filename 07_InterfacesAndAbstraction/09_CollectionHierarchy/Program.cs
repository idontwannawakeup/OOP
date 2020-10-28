using _09_CollectionHierarchy.Models;
using System;

namespace _09_CollectionHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());

            foreach (var item in input)
                Console.Write($"{addCollection.Add(item)} ");
            Console.WriteLine();

            foreach (var item in input)
                Console.Write($"{addRemoveCollection.Add(item)} ");
            Console.WriteLine();

            foreach (var item in input)
                Console.Write($"{myList.Add(item)} ");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
                Console.Write($"{addRemoveCollection.Remove()} ");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
                Console.Write($"{myList.Remove()} ");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
