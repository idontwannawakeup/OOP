using System;

namespace _02_CreatingConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(20);
            Console.WriteLine($"{nameof(person)}: {person.Name}, age: {person.Age}");

            Console.ReadKey();
        }
    }
}
