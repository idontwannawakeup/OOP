using System;
using System.Collections.Generic;
using System.Text;

namespace _02_KingsGambit.Models
{
    class Footman : Servant
    {
        public override void OnKingsGetAttacked()
        {
            Console.WriteLine($"Footman {Name} is panicking!");
        }

        public Footman(string name)
            : base(name)
        { }
    }
}
