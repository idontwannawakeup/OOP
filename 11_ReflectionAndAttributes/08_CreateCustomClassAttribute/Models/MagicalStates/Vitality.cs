namespace _08_CreateCustomClassAttribute.Models.MagicalStates
{
    class Vitality : MagicalState
    {
        private const int defaultAdditionToMinDamage = 0;

        private const int defaultAdditionToMaxDamage = 0;

        public Vitality()
            : base(defaultAdditionToMinDamage, defaultAdditionToMaxDamage)
        { }
    }
}
