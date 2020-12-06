namespace _09_Refactoring.Models.Gems
{
    using Clarities;

    public class Amethyst : Gem
    {
        private const int defaultStrengthBonus = 2;

        private const int defaultAgilityBonus = 8;

        private const int defaultVitalityBonus = 4;

        public Amethyst(Clarity clarity)
            : base(clarity, defaultStrengthBonus, defaultAgilityBonus, defaultVitalityBonus)
        { }
    }
}
