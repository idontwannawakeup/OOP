namespace _09_Refactoring.Models.Rarities
{
    public class Rare : Rarity
    {
        private const int defaultDamageModifier = 3;

        public Rare()
            : base(defaultDamageModifier)
        { }
    }
}
