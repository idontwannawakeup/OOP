using _02_KingsGambit.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_KingsGambit
{
    class Program
    {
        static void Main(string[] args)
        {
            var king = new King(Console.ReadLine());
            var servants = Console.ReadLine()
                .Split(' ')
                .Select(element => (Servant)new RoyalGuard(element))
                .ToList();

            servants.AddRange(Console.ReadLine()
                .Split(' ')
                .Select(element => (Servant)new Footman(element))
                .ToList());

            foreach (var item in servants)
                king.Attacked += item.OnKingsGetAttacked;

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Attack King")
                {
                    king.Attack();
                }
                else
                {
                    string name = input.Split(' ')[1];
                    var servantToKill = servants.Find(element => element.Name == name);

                    if (servantToKill != null)
                    {
                        king.Attacked -= servantToKill.OnKingsGetAttacked;
                        servants.Remove(servantToKill);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
