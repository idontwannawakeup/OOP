﻿namespace _09_Refactoring.Models.MagicalStates
{
    public class Strength : MagicalState
    {
        private const int defaultAdditionToMinDamage = 2;

        private const int defaultAdditionToMaxDamage = 3;

        public Strength()
            : base(defaultAdditionToMinDamage, defaultAdditionToMaxDamage)
        { }
    }
}
