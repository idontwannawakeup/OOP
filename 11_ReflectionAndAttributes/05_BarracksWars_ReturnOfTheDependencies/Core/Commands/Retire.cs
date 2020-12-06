namespace _05_BarracksWars_ReturnOfTheDependencies.Core.Commands
{
    using System;
    using Contracts;
    using Attributes;

    public class Retire : Command
    {
        [Inject]
        private IRepository repository;

        public override string Execute()
        {
            try
            {
                string unitType = Data[1];
                repository.RemoveUnit(unitType);
                return $"{unitType} retired!";
            }
            catch (ArgumentException ae)
            {
                return ae.Message;
            }
        }

        public Retire(string[] data)
            : base(data)
        { }
    }
}
