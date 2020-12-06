namespace _05_BarracksWars_ReturnOfTheDependencies.Core.Commands
{
    using System;

    public class Fight : Command
    {
        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }

        public Fight(string[] data)
            : base(data)
        { }
    }
}
