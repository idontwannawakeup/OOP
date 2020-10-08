using System;
using System.Collections.Generic;
using System.Text;

namespace _05_GreedyTimes
{
    class TreasureItem
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public TreasureItem(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
