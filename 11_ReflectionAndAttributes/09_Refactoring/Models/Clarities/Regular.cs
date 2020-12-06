namespace _09_Refactoring.Models.Clarities
{
    public class Regular : Clarity
    {
        private const int defaultIncreasement = 2;

        public Regular()
            : base(defaultIncreasement)
        { }
    }
}
