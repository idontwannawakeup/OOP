namespace _09_Refactoring.Core.Factories
{
    using Interfaces;
    using Models.Rarities;
    using System;

    public class RarityFactory : IRarityFactory
    {
        public IRarity CreateInstance(string typeName)
        {
            string raritiesNamespace = typeof(Rarity).Namespace;
            Type rarityType = Type.GetType($"{raritiesNamespace}.{typeName}");
            IRarity rarity = (IRarity)Activator.CreateInstance(rarityType);
            return rarity;
        }
    }
}
