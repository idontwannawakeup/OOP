using _09_CollectionHierarchy.Interfaces;
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

            AddAndPrint(addCollection, input);
            AddAndPrint(addRemoveCollection, input);
            AddAndPrint(myList, input);

            RemoveAndPrint(addRemoveCollection, n);
            RemoveAndPrint(myList, n);

            Console.ReadKey();
        }

        static void AddAndPrint(IAddable collection, string[] values)
        {
            foreach (var item in values)
                Console.Write($"{collection.Add(item)} ");
            Console.WriteLine();
        }

        static void RemoveAndPrint(IRemoveable collection, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write($"{collection.Remove()} ");
            Console.WriteLine();
        }
    }
}
