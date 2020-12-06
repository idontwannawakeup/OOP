namespace _08_CreateCustomClassAttribute.Models.Weapons
{
    using Rarities;

    class Axe : Weapon
    {
        private const int defaultMinDamage = 5;

        private const int defaultMaxDamage = 10;

        private const int defaultAmountOfSockets = 4;

        public Axe(string name, Rarity rarity)
            : base(name, rarity, defaultMinDamage, defaultMaxDamage, defaultAmountOfSockets)
        { }
    }
}
