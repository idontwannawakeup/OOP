using System;
using System.Collections.Generic;
using System.Text;

namespace _02_KingsGambit.Models
{
    class RoyalGuard : Servant
    {
        public override void OnKingsGetAttacked()
        {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }

        public RoyalGuard(string name)
            : base(name)
        { }
    }
}
