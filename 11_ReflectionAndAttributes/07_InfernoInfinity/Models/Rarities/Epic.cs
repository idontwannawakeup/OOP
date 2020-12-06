namespace _07_InfernoInfinity.Models.Rarities
{
    class Epic : Rarity
    {
        private const int defaultDamageModifier = 1;

        public Epic()
            : base(defaultDamageModifier)
        { }
    }
}
