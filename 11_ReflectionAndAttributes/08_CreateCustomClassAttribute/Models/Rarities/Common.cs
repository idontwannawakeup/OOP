namespace _08_CreateCustomClassAttribute.Models.Rarities
{
    class Common : Rarity
    {
        private const int defaultDamageModifier = 1;

        public Common()
            : base(defaultDamageModifier)
        { }
    }
}
