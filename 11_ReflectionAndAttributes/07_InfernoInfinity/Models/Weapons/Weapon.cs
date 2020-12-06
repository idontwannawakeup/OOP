namespace _07_InfernoInfinity.Models.Weapons
{
    using Rarities;
    using MagicalStates;
    using Gems;
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    class Weapon
    {
        public string Name { get; }

        public Rarity WeaponRarity { get; }

        public int RawMinDamage => rawMinDamage;

        public int RawMaxDamage => rawMaxDamage;

        public int ModifiedMinDamage => CalculateModifiedMinDamage();

        public int ModifiedMaxDamage => CalculateModifiedMaxDamage();

        private int rawMinDamage;

        private int rawMaxDamage;

        private MagicalState[] magicalStates = new MagicalState[]
        {
            new Strength(),
            new Agility(),
            new Vitality()
        };

        private Gem[] gems;

        public void AddGemInSocket(int index, Gem gem)
        {
            if (index >= 0 && index < gems.Length)
                gems[index] = gem;
        }

        public void RemoveGemFromSocket(int index)
        {
            if (index >= 0 && index < gems.Length)
                gems[index] = null;
        }

        public void PrintInfo()
        {
            StringBuilder infoBuilder = new StringBuilder();
            infoBuilder.Append($"{Name}: ");

            List<string> stats = new List<string>();
            stats.Add($"{ModifiedMinDamage}-{ModifiedMaxDamage} Damage");
            foreach (MagicalState state in magicalStates)
            {
                Type type = state.GetType();
                stats.Add($"+{GetTotalBonusForState(type)} {type.Name}");
            }
            infoBuilder.Append(string.Join(", ", stats));

            string info = infoBuilder.ToString();
            Console.WriteLine(info);
        }

        private int GetTotalBonusForState(Type magicalState)
        {
            int totalBonusForState = 0;
            foreach (Gem gem in gems)
                if (gem != null)
                    totalBonusForState += gem.GetBonusForStat(magicalState);

            return totalBonusForState;
        }

        private int CalculateModifiedMinDamage()
        {
            int modified = rawMinDamage * WeaponRarity.DamageModifier;

            modified += magicalStates.Sum(state =>
                state.AdditionToMinDamage * GetTotalBonusForState(state.GetType())
            );

            return modified;
        }

        private int CalculateModifiedMaxDamage()
        {
            int modified = rawMaxDamage * WeaponRarity.DamageModifier;

            modified += magicalStates.Sum(state =>
                state.AdditionToMaxDamage * GetTotalBonusForState(state.GetType())
            );

            return modified;
        }

        public Weapon(string name, Rarity rarity, int rawMinDamage, int rawMaxDamage, int socketsAmount)
        {
            Name = name;
            WeaponRarity = rarity;
            this.rawMinDamage = rawMinDamage;
            this.rawMaxDamage = rawMaxDamage;
            gems = new Gem[socketsAmount];
        }
    }
}
