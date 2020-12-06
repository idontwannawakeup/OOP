namespace _09_Refactoring.Models.Weapons
{
    using Rarities;

    public class Knife : Weapon
    {
        private const int defaultMinDamage = 3;

        private const int defaultMaxDamage = 4;

        private const int defaultAmountOfSockets = 2;

        public Knife(string name, Rarity rarity)
            : base(name, rarity, defaultMinDamage, defaultMaxDamage, defaultAmountOfSockets)
        { }
    }
}
