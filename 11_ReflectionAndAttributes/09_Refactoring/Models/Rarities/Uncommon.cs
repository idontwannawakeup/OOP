namespace _09_Refactoring.Models.Rarities
{
    public class Uncommon : Rarity
    {
        private const int defaultDamageModifier = 2;

        public Uncommon()
            : base(defaultDamageModifier)
        { }
    }
}
