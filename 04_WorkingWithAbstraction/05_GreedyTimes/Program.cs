using System;

namespace _05_GreedyTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Bag robberyBag = new Bag(capacity);

            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length; i += 2)
            {
                // Gold check
                if (input[i].Equals("Gold") &&
                    int.Parse(input[i + 1]) <= robberyBag.Capacity)
                {
                    robberyBag.UpdateTreasures("Gold", "gold", int.Parse(input[i + 1]));
                }
                // Gem check
                else if (input[i].Substring(input[i].Length - 3).Equals("gem") &&
                    robberyBag.AmountOfTreasures("Gold") >=
                    robberyBag.AmountOfTreasures("Gem") + int.Parse(input[i + 1]))
                {
                    robberyBag.UpdateTreasures("Gem", input[i], int.Parse(input[i + 1]));
                }
                // Cash check
                else if (input[i].Length == 3 &&
                    robberyBag.AmountOfTreasures("Gem") >=
                    robberyBag.AmountOfTreasures("Cash") + int.Parse(input[i + 1]))
                {
                    robberyBag.UpdateTreasures("Cash", input[i], int.Parse(input[i + 1]));
                }
            }

            robberyBag.Print();

            Console.ReadKey();
        }
    }
}
