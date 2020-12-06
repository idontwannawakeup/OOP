namespace _05_BarracksWars_ReturnOfTheDependencies.Core.Commands
{
    using Contracts;
    using Attributes;

    public class Report : Command
    {
        [Inject]
        private IRepository repository;

        public override string Execute()
        {
            string output = repository.Statistics;
            return output;
        }

        public Report(string[] data)
            : base(data)
        { }
    }
}
