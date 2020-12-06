namespace _09_Refactoring.Models.Rarities
{
    public class Common : Rarity
    {
        private const int defaultDamageModifier = 1;

        public Common()
            : base(defaultDamageModifier)
        { }
    }
}
