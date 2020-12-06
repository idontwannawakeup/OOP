namespace _08_CreateCustomClassAttribute.Models.Rarities
{
    class Rare : Rarity
    {
        private const int defaultDamageModifier = 3;

        public Rare()
            : base(defaultDamageModifier)
        { }
    }
}
