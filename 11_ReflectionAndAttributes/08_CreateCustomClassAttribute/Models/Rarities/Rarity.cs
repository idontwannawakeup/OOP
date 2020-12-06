namespace _08_CreateCustomClassAttribute.Models.Rarities
{
    class Rarity
    {
        public int DamageModifier { get; }

        public Rarity(int damageModifier)
        {
            DamageModifier = damageModifier;
        }
    }
}
