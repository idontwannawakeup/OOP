using _05_KingsGambitExtended.Models;
using System;
using System.Linq;

namespace _05_KingsGambitExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            var king = new King(Console.ReadLine());
            var kingsServants = new KingsServants(king);

            kingsServants.AddServants(Console.ReadLine()
                .Split(' ')
                .Select(element => (Servant)new RoyalGuard(element))
                .ToList());

            kingsServants.AddServants(Console.ReadLine()
                .Split(' ')
                .Select(element => (Servant)new Footman(element))
                .ToList());

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Attack King")
                    king.Attack();
                else
                    kingsServants.KillServant(input.Split(' ')[1]);
            }

            Console.ReadKey();
        }
    }
}
