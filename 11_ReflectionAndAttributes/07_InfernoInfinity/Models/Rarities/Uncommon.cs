namespace _07_InfernoInfinity.Models.Rarities
{
    class Uncommon : Rarity
    {
        private const int defaultDamageModifier = 2;

        public Uncommon()
            : base(defaultDamageModifier)
        { }
    }
}
