using _10_ExplicitInterfaces.Interfaces;
using _10_ExplicitInterfaces.Models;
using System;
using System.Collections.Generic;

namespace _10_ExplicitInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var citizens = new List<Citizen>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] info = input.Split(' ');
                citizens.Add(new Citizen(info[0], info[1], int.Parse(info[2])));
                input = Console.ReadLine();
            }

            foreach (var item in citizens)
            {
                Console.WriteLine(((IPerson)item).GetName());
                Console.WriteLine(((IResident)item).GetName());
            }

            Console.ReadKey();
        }
    }
}
