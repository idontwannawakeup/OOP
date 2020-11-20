using System;
using System.Collections.Generic;
using System.Text;

namespace _05_KingsGambitExtended.Models
{
    class King
    {
        public event Action Attacked;

        public string Name { get; set; }

        public void Attack()
        {
            Console.WriteLine($"King {Name} is under attack!");
            Attacked?.Invoke();
        }

        public King(string name)
        {
            Name = name;
        }
    }
}
