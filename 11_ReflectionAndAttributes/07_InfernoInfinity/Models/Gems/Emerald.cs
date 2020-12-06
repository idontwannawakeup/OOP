namespace _07_InfernoInfinity.Models.Gems
{
    using Clarities;

    class Emerald : Gem
    {
        private const int defaultStrengthBonus = 1;

        private const int defaultAgilityBonus = 4;

        private const int defaultVitalityBonus = 9;

        public Emerald(Clarity clarity)
            : base(clarity, defaultStrengthBonus, defaultAgilityBonus, defaultVitalityBonus)
        { }
    }
}
