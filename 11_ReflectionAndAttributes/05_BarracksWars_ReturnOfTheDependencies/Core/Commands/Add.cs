namespace _05_BarracksWars_ReturnOfTheDependencies.Core.Commands
{
    using Contracts;
    using Attributes;

    public class Add : Command
    {
        [Inject]
        private IRepository repository;

        [Inject]
        private IUnitFactory unitFactory;

        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToAdd = unitFactory.CreateUnit(unitType);
            repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }

        public Add(string[] data)
            : base(data)
        { }
    }
}
