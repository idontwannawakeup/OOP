namespace _04_BarracksWars_TheCommandsStrikeBack.Core.Commands
{
    using Contracts;
    using System;

    public class Retire : Command
    {
        public override string Execute()
        {
            try
            {
                string unitType = Data[1];
                Repository.RemoveUnit(unitType);
                return $"{unitType} retired!";
            }
            catch (ArgumentException ae)
            {
                return ae.Message;
            }
        }

        public Retire(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        { }
    }
}
