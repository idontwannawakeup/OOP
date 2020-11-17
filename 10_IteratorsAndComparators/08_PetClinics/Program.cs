using _08_PetClinics.Models;
using System;
using System.Collections.Generic;

namespace _08_PetClinics
{
    class Program
    {
        static void Main(string[] args)
        {
            var holding = new PetClinicsHolding();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ');

                string command = info[0];
                switch (command)
                {
                    case "Create":
                        holding.TryCreate(info);
                        break;
                    case "Add":
                        Console.WriteLine(holding.TryAddPet(info[1], info[2]));
                        break;
                    case "Release":
                        Console.WriteLine(holding.TryRelease(info[1]));
                        break;
                    case "HasEmptyRooms":
                        Console.WriteLine(holding.HasEmptyRooms(info[1]));
                        break;
                    case "Print":
                        holding.Print(info);
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
