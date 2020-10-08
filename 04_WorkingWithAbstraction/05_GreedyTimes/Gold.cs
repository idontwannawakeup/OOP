using System;

namespace _05_GreedyTimes
{
    class Gold : StolenTreasures
    {
        private TreasureItem gold;
        public override int TotalAmount { get => gold.Value; }

        public override void Add(string name, int value)
        {
            gold.Name = name;
            gold.Value += value;
        }

        public override void Print()
        {
            Console.WriteLine($"##{Type} - {TotalAmount}");
        }

        public Gold(int value)
            : base("Gold")
        {
            gold = new TreasureItem(Type, value);
        }
    }
}
