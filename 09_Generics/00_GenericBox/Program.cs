using _00_GenericBox.Models;
using System;

namespace _00_GenericBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var integerBox = new Box<int>(123123);
            Console.WriteLine(integerBox);

            var stringBox = new Box<string>("life in a box");
            Console.WriteLine(stringBox);

            Console.ReadKey();
        }
    }
}
