using _09_LinkedListTraversal.Models;
using System;

namespace _09_LinkedListTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new CustomLinkedList<int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ');

                if (info[0] == "Add")
                    numbers.Add(int.Parse(info[1]));
                else
                    numbers.Remove(int.Parse(info[1]));
            }

            Console.WriteLine(numbers.Count);
            foreach (var item in numbers)
                Console.Write($"{item} ");


            Console.ReadKey();
        }
    }
}
