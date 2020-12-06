namespace _09_Refactoring.Models.Gems
{
    using Clarities;

    public class Emerald : Gem
    {
        private const int defaultStrengthBonus = 1;

        private const int defaultAgilityBonus = 4;

        private const int defaultVitalityBonus = 9;

        public Emerald(Clarity clarity)
            : base(clarity, defaultStrengthBonus, defaultAgilityBonus, defaultVitalityBonus)
        { }
    }
}
