namespace _09_Refactoring.Models.Gems
{
    using Interfaces;
    using MagicalStates;
    using System;
    using System.Collections.Generic;

    public class Gem : IGem
    {
        public IClarity GemClarity { get; }

        private Dictionary<Type, int> bonuses = new Dictionary<Type, int>
        {
            { typeof(Strength), 0 },
            { typeof(Agility), 0 },
            { typeof(Vitality), 0 },
        };

        public int GetBonusForStat(Type magicalStateType)
        {
            if (!this.bonuses.ContainsKey(magicalStateType))
                throw new ArgumentException("No bonus for such magical state");

            return this.bonuses[magicalStateType] + this.GemClarity.StatIncreasement;
        }

        public Gem
        (
            IClarity gemClarity,
            int bonusToStrength,
            int bonusToAgility,
            int bonusToVitality
        )
        {
            this.GemClarity = gemClarity;

            this.bonuses[typeof(Strength)] = bonusToStrength;
            this.bonuses[typeof(Agility)] = bonusToAgility;
            this.bonuses[typeof(Vitality)] = bonusToVitality;
        }
    }
}
