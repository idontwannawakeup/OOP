namespace _08_CreateCustomClassAttribute.Models.Gems
{
    using MagicalStates;
    using Clarities;
    using System;
    using System.Collections.Generic;

    class Gem
    {
        public Clarity GemClarity { get; }

        private Dictionary<Type, int> bonuses = new Dictionary<Type, int>
        {
            { typeof(Strength), 0 },
            { typeof(Agility), 0 },
            { typeof(Vitality), 0 },
        };

        public int GetBonusForStat(Type magicalStateType)
        {
            if (!bonuses.ContainsKey(magicalStateType))
                throw new ArgumentException("No bonus for such magical state");

            return bonuses[magicalStateType] + GemClarity.StatIncreasement;
        }

        public Gem(Clarity gemClarity, int bonusToStrength, int bonusToAgility, int bonusToVitality)
        {
            GemClarity = gemClarity;

            bonuses[typeof(Strength)] = bonusToStrength;
            bonuses[typeof(Agility)] = bonusToAgility;
            bonuses[typeof(Vitality)] = bonusToVitality;
        }
    }
}
