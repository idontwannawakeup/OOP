﻿namespace _01_RawData
{
    class Cargo
    {
        public int Weight { get; }
        public string Type { get; }

        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }
}
