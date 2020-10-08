using System;
using System.Collections.Generic;
using System.Text;

namespace _05_GreedyTimes
{
    class Bag
    {
        private List<StolenTreasures> treasures;
        public int Capacity { get; }

        public int AmountOfTreasures(string type)
        {
            foreach (var treasure in treasures)
                if (treasure.Type == type)
                    return treasure.TotalAmount;
            return 0;
        }

        public void UpdateTreasures(string treasureType, string name, int value)
        {
            foreach (var treasure in treasures)
                if (treasure.Type.Equals(treasureType))
                    treasure.Add(name, value);
        }

        public void Print()
        {
            for (int i = 0; i < treasures.Count; i++)
                for (int j = 0; j < treasures.Count; j++)
                    if (treasures[i].TotalAmount > treasures[j].TotalAmount)
                    {
                        var tmp = treasures[i];
                        treasures[i] = treasures[j];
                        treasures[j] = tmp;
                    }

            foreach (var treasure in treasures)
                if (treasure.TotalAmount != 0)
                {
                    Console.WriteLine($"<{treasure.Type}> ${treasure.TotalAmount}");
                    treasure.Print();
                }
                
        }

        public Bag(int capacity)
        {
            Capacity = capacity;
            treasures = new List<StolenTreasures>
            {
                new Gold(0),
                new Treasure("Gem"),
                new Treasure("Cash"),
            };
        }
    }
}
