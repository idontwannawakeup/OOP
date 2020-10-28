using _01_DefineAnInterfaceIPerson.Interfaces;
using _01_DefineAnInterfaceIPerson.Models;
using System;

namespace _01_DefineAnInterfaceIPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            IPerson person = new Citizen(name, age);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            Console.ReadKey();
        }
    }
}
