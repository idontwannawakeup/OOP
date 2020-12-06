namespace _09_Refactoring.Models.Weapons
{
    using Rarities;

    public class Sword : Weapon
    {
        private const int defaultMinDamage = 4;

        private const int defaultMaxDamage = 6;

        private const int defaultAmountOfSockets = 3;

        public Sword(string name, Rarity rarity)
            : base(name, rarity, defaultMinDamage, defaultMaxDamage, defaultAmountOfSockets)
        { }
    }
}
