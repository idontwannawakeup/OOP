using System;
using System.Collections.Generic;
using System.Text;

namespace _05_KingsGambitExtended.Models
{
    class KingsServants
    {
        private King king;

        private List<Servant> servants = new List<Servant>();

        public void AddServants(List<Servant> newServants)
        {
            foreach (var item in newServants)
            {
                king.Attacked += item.OnKingsGetAttacked;
                item.Death += OnServantDeath;
            }

            servants.AddRange(newServants);
        }

        public void KillServant(string name)
        {
            var servantToKill = servants.Find(element => element.Name == name);
            servantToKill?.Kill();
        }

        private void OnServantDeath(string name)
        {
            var servantToKill = servants.Find(element => element.Name == name);

            if (servantToKill != null)
            {
                king.Attacked -= servantToKill.OnKingsGetAttacked;
                servants.Remove(servantToKill);
            }
        }

        public KingsServants(King king)
        {
            this.king = king;
        }
    }
}
