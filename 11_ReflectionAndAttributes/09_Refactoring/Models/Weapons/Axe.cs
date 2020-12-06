namespace _09_Refactoring.Models.Weapons
{
    using Rarities;

    public class Axe : Weapon
    {
        private const int defaultMinDamage = 5;

        private const int defaultMaxDamage = 10;

        private const int defaultAmountOfSockets = 4;

        public Axe(string name, Rarity rarity)
            : base(name, rarity, defaultMinDamage, defaultMaxDamage, defaultAmountOfSockets)
        { }
    }
}
