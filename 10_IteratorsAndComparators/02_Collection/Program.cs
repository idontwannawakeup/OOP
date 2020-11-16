using _02_Collection.Models;
using System;
using System.Linq;

namespace _02_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            input.Remove("Create");
            var iterator = new ListyIterator<string>(input);

            string command;
            while ((command = Console.ReadLine()) != "END")
                try
                {
                    switch (command)
                    {
                        case "Move":
                            Console.WriteLine(iterator.Move());
                            break;
                        case "HasNext":
                            Console.WriteLine(iterator.HasNext());
                            break;
                        case "Print":
                            iterator.Print();
                            break;
                        case "PrintAll":
                            foreach (var item in iterator)
                                Console.Write($"{item} ");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

            Console.ReadKey();
        }
    }
}
