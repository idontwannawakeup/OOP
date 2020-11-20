using System;
using System.Collections.Generic;
using System.Text;

namespace _05_KingsGambitExtended.Models
{
    abstract class Servant
    {
        public event Action<string> Death;

        public string Name { get; set; }

        public int KillCount
        {
            get => killCount;

            set
            {
                killCount = value;
                if (killCount >= MaxKillCount)
                    Death?.Invoke(Name);
            }
        }

        private int killCount = 0;

        protected virtual int MaxKillCount { get; } = 0;

        public void Kill()
        {
            KillCount++;
        }

        public abstract void OnKingsGetAttacked();

        public Servant(string name)
        {
            Name = name;
        }
    }
}
