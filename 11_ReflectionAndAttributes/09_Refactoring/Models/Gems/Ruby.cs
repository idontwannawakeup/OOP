namespace _09_Refactoring.Models.Gems
{
    using Clarities;

    public class Ruby : Gem
    {
        private const int defaultStrengthBonus = 7;

        private const int defaultAgilityBonus = 2;

        private const int defaultVitalityBonus = 5;

        public Ruby(Clarity clarity)
            : base(clarity, defaultStrengthBonus, defaultAgilityBonus, defaultVitalityBonus)
        { }
    }
}
