using System;
using System.Collections.Generic;

namespace _05_GreedyTimes
{
    class Treasure : StolenTreasures
    {
        private List<TreasureItem> gems = new List<TreasureItem>();
        public override int TotalAmount
        {
            get
            {
                int amount = 0;
                foreach (var gem in gems)
                    amount += gem.Value;
                return amount;
            }
        }

        public override void Print()
        {
            for (int i = 0; i < gems.Count; i++)
                for (int j = 0; j < gems.Count; j++)
                    if (gems[i].Name.CompareTo(gems[j].Name) < 0)
                    {
                        var tmp = gems[i];
                        gems[i] = gems[j];
                        gems[j] = tmp;
                    }

            foreach (var item in gems)
                Console.WriteLine($"##{item.Name} - {item.Value}");
        }

        public override void Add(string name, int value)
        {
            gems.Add(new TreasureItem(name, value));
        }

        public Treasure(string type) : base(type) { }
    }
}
