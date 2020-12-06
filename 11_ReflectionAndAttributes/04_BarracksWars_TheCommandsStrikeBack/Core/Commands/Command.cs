namespace _04_BarracksWars_TheCommandsStrikeBack.Core.Commands
{
    using Contracts;

    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IUnitFactory unitFactory;

        protected string[] Data
        {
            get => data;
            set => data = value;
        }

        protected IRepository Repository
        {
            get => repository;
            set => repository = value;
        }

        protected IUnitFactory UnitFactory
        {
            get => unitFactory;
            set => unitFactory = value;
        }

        public abstract string Execute();

        protected Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            Data = data;
            Repository = repository;
            UnitFactory = unitFactory;
        }
    }
}
