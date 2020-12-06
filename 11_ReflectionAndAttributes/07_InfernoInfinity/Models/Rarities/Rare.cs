namespace _07_InfernoInfinity.Models.Rarities
{
    class Rare : Rarity
    {
        private const int defaultDamageModifier = 3;

        public Rare()
            : base(defaultDamageModifier)
        { }
    }
}
