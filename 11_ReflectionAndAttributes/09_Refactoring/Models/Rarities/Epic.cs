namespace _09_Refactoring.Models.Rarities
{
    public class Epic : Rarity
    {
        private const int defaultDamageModifier = 1;

        public Epic()
            : base(defaultDamageModifier)
        { }
    }
}
