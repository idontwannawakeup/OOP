using System;
using System.Collections.Generic;
using System.Text;

namespace _05_KingsGambitExtended.Models
{
    class Footman : Servant
    {
        protected override int MaxKillCount { get; } = 2;

        public override void OnKingsGetAttacked()
        {
            Console.WriteLine($"Footman {Name} is panicking!");
        }

        public Footman(string name)
            : base(name)
        { }
    }
}
