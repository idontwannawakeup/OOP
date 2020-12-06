namespace _09_Refactoring.Core.Factories
{
    using Interfaces;
    using Models.Clarities;
    using System;

    public class ClarityFactory : IClarityFactory
    {
        public IClarity CreateInstance(string typeName)
        {
            string claritiesNamespace = typeof(Clarity).Namespace;
            Type clarityType = Type.GetType($"{claritiesNamespace}.{typeName}");
            IClarity clarity = (IClarity)Activator.CreateInstance(clarityType);
            return clarity;
        }
    }
}
