namespace _09_Refactoring.Models.MagicalStates
{
    public class Agility : MagicalState
    {
        private const int defaultAdditionToMinDamage = 1;

        private const int defaultAdditionToMaxDamage = 4;

        public Agility()
            : base(defaultAdditionToMinDamage, defaultAdditionToMaxDamage)
        { }
    }
}
