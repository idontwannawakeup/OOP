namespace _04_BarracksWars_TheCommandsStrikeBack.Core.Commands
{
    using Contracts;
    using System;

    public class Fight : Command
    {
        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }

        public Fight(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        { }
    }
}
