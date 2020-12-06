namespace _05_BarracksWars_ReturnOfTheDependencies.Core.Commands
{
    using Contracts;

    public abstract class Command : IExecutable
    {
        private string[] data;

        protected string[] Data
        {
            get => data;
            set => data = value;
        }

        public abstract string Execute();

        protected Command(string[] data)
        {
            Data = data;
        }
    }
}
