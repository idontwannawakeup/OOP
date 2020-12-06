namespace _04_BarracksWars_TheCommandsStrikeBack.Core.Commands
{
    using Contracts;

    public class Report : Command
    {
        public override string Execute()
        {
            string output = Repository.Statistics;
            return output;
        }

        public Report(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        { }
    }
}
