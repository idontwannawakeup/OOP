namespace _09_Refactoring.Models.Rarities
{
    using Interfaces;

    public class Rarity : IRarity
    {
        public int DamageModifier { get; }

        public Rarity(int damageModifier)
        {
            this.DamageModifier = damageModifier;
        }
    }
}
