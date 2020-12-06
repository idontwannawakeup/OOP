namespace _05_BarracksWars_ReturnOfTheDependencies.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            string unitsNamespace = "_05_BarracksWars_ReturnOfTheDependencies.Models.Units";
            string fullTypeName = $"{unitsNamespace}.{unitType}";
            return (IUnit)Activator.CreateInstance(Type.GetType(fullTypeName));
        }
    }
}
