using System;
using System.Collections.Generic;
using System.Text;

namespace _02_KingsGambit.Models
{
    abstract class Servant
    {
        public string Name { get; set; }

        public abstract void OnKingsGetAttacked();

        public Servant(string name)
        {
            Name = name;
        }
    }
}
