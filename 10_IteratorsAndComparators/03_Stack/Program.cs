using _03_Stack.Models;
using System;
using System.Linq;

namespace _03_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var customStack = new CustomStack<int>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "Pop")
                {
                    try
                    {
                        customStack.Pop();
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
                else
                {
                    var numbers = input
                        .Replace(",", "")
                        .Split(' ')
                        .Where(element => element != "Push")
                        .Select(int.Parse)
                        .ToList();

                    customStack.Push(numbers);
                }
            }

            for (int i = 0; i < 2; i++)
                foreach (var item in customStack)
                    Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
