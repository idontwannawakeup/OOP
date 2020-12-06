namespace _08_CreateCustomClassAttribute.Models.Rarities
{
    class Uncommon : Rarity
    {
        private const int defaultDamageModifier = 2;

        public Uncommon()
            : base(defaultDamageModifier)
        { }
    }
}
