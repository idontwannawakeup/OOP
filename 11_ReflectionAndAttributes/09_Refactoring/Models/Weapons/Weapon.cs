﻿namespace _09_Refactoring.Models.Weapons
{
    using Enums;
    using Interfaces;
    using MagicalStates;
    using Models.Gems;
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    public class Weapon : IWeapon
    {
        public string Name { get; }

        public IRarity WeaponRarity { get; }

        public int RawMinDamage => rawMinDamage;

        public int RawMaxDamage => rawMaxDamage;

        public int ModifiedMinDamage => CalculateModifiedMinDamage();

        public int ModifiedMaxDamage => CalculateModifiedMaxDamage();

        public string Info
        {
            get
            {
                var infoBuilder = new StringBuilder();
                infoBuilder.Append($"{this.Name}: ");

                var stats = new List<string>();

                stats.Add($"{this.ModifiedMinDamage}-{this.ModifiedMaxDamage} Damage");
                foreach (MagicalState state in this.magicalStates)
                {
                    Type type = state.GetType();
                    stats.Add($"+{GetTotalBonusForState(type)} {type.Name}");
                }

                infoBuilder.Append(string.Join(", ", stats));

                return infoBuilder.ToString();
            }
        }

        private int rawMinDamage;

        private int rawMaxDamage;

        private MagicalState[] magicalStates = new MagicalState[]
        {
            new Strength(),
            new Agility(),
            new Vitality()
        };

        private IGem[] gems;

        public void AddGemInSocket(int index, IGem gem)
        {
            if (index >= 0 && index < this.gems.Length)
                this.gems[index] = gem;
        }

        public void RemoveGemFromSocket(int index)
        {
            if (index >= 0 && index < this.gems.Length)
                this.gems[index] = new EmptyGem();
        }

        private int GetTotalBonusForState(Type magicalState) =>
            this.gems.Sum(element => element.GetBonusForStat(magicalState));

        private int CalculateModifiedMinDamage() =>
            CalculateDamage(this.rawMinDamage, DamageRange.Min);

        private int CalculateModifiedMaxDamage() =>
            CalculateDamage(this.rawMaxDamage, DamageRange.Max);

        private int CalculateDamage(int rawDamage, DamageRange damageRange)
        {
            int modifiedDamage = rawDamage * this.WeaponRarity.DamageModifier;
            modifiedDamage += this.magicalStates.Sum
            (
                state => state.Additions[damageRange] * GetTotalBonusForState(state.GetType())
            );

            return modifiedDamage;
        }

        public Weapon
        (
            string name,
            IRarity rarity,
            int rawMinDamage,
            int rawMaxDamage,
            int socketsAmount
        )
        {
            this.Name = name;
            this.WeaponRarity = rarity;
            this.rawMinDamage = rawMinDamage;
            this.rawMaxDamage = rawMaxDamage;
            this.gems = new IGem[socketsAmount];
            for (int i = 0; i < this.gems.Length; i++)
                this.gems[i] = new EmptyGem();
        }
    }
}
