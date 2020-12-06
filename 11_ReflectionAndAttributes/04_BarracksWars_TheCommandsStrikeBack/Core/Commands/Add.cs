namespace _04_BarracksWars_TheCommandsStrikeBack.Core.Commands
{
    using Contracts;

    public class Add : Command
    {
        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToAdd = UnitFactory.CreateUnit(unitType);
            Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }

        public Add(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        { }
    }
}
