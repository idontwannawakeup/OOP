namespace _03_BarracksWars_ANewFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            string unitsNamespace = @"_03_BarracksWars_ANewFactory.Models.Units";
            string fullType = $"{unitsNamespace}.{unitType}";
            return (IUnit)Type.GetType(fullType).Assembly.CreateInstance(fullType);
        }
    }
}
