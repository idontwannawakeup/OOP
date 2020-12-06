namespace _04_BarracksWars_TheCommandsStrikeBack.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            string unitsNamespace = "_04_BarracksWars_TheCommandsStrikeBack.Models.Units";
            string fullTypeName = $"{unitsNamespace}.{unitType}";
            return (IUnit)Activator.CreateInstance(Type.GetType(fullTypeName));
        }
    }
}
