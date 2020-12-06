namespace _09_Refactoring.Core.Factories
{
    using Interfaces;
    using Models.Gems;
    using System;

    public class GemFactory : IGemFactory
    {
        private IClarityFactory clarityFactory;

        public IGem CreateInstance(string typeName, string clarityTypeName)
        {
            string gemsNamespace = typeof(Gem).Namespace;
            Type gemType = Type.GetType($"{gemsNamespace}.{typeName}");

            IClarity clarity = this.clarityFactory.CreateInstance(clarityTypeName);
            object[] gemArgs = new object[] { clarity };

            IGem gem = (IGem)Activator.CreateInstance(gemType, gemArgs);
            return gem;
        }

        public GemFactory()
            : this(new ClarityFactory())
        { }

        public GemFactory(IClarityFactory clarityFactory)
        {
            this.clarityFactory = clarityFactory;
        }
    }
}
