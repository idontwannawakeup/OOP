using System;
using System.Collections.Generic;
using System.Text;

namespace _05_KingsGambitExtended.Models
{
    class RoyalGuard : Servant
    {
        protected override int MaxKillCount { get; } = 3;

        public override void OnKingsGetAttacked()
        {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }

        public RoyalGuard(string name)
            : base(name)
        { }
    }
}
