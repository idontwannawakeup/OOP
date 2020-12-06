namespace _09_Refactoring.Models.MagicalStates
{
    using Enums;
    using System.Collections.Generic;

    public class MagicalState
    {
        public int AdditionToMinDamage { get; }

        public int AdditionToMaxDamage { get; }

        public Dictionary<DamageRange, int> Additions { get; }

        public MagicalState(int additionToMinDamage, int additionToMaxDamage)
        {
            this.AdditionToMinDamage = additionToMinDamage;
            this.AdditionToMaxDamage = additionToMaxDamage;

            Additions = new Dictionary<DamageRange, int>
            {
                { DamageRange.Min, this.AdditionToMinDamage },
                { DamageRange.Max, this.AdditionToMaxDamage }
            };
        }
    }
}
