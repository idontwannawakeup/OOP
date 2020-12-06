namespace _07_InfernoInfinity.Models.Rarities
{
    class Common : Rarity
    {
        private const int defaultDamageModifier = 1;

        public Common()
            : base(defaultDamageModifier)
        { }
    }
}
