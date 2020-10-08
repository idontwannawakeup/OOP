namespace _05_GreedyTimes
{
    abstract class StolenTreasures
    {
        public string Type { get; }

        abstract public int TotalAmount { get; }
        abstract public void Add(string name, int value);
        abstract public void Print();

        public StolenTreasures(string type)
        {
            Type = type;
        }
    }
}
