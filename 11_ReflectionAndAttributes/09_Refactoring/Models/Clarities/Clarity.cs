namespace _09_Refactoring.Models.Clarities
{
    using Interfaces;

    public class Clarity : IClarity
    {
        public int StatIncreasement { get; }

        public Clarity(int statIncreasement)
        {
            this.StatIncreasement = statIncreasement;
        }
    }
}
