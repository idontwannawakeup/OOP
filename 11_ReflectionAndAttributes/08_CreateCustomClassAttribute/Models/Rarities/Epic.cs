namespace _08_CreateCustomClassAttribute.Models.Rarities
{
    class Epic : Rarity
    {
        private const int defaultDamageModifier = 1;

        public Epic()
            : base(defaultDamageModifier)
        { }
    }
}
