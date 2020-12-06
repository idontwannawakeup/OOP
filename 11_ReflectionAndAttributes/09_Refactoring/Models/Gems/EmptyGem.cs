namespace _09_Refactoring.Models.Gems
{
    using Clarities;

    class EmptyGem : Gem
    {
        public EmptyGem()
            : base(new Clarity(0), 0, 0, 0)
        { }
    }
}
