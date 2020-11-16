using _01_ListyIterator.Models;
using System;
using System.Linq;

namespace _01_ListyIterator
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
                        case "Move": Console.WriteLine(iterator.Move()); break;
                        case "HasNext": Console.WriteLine(iterator.HasNext()); break;
                        case "Print": iterator.Print(); break;
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
