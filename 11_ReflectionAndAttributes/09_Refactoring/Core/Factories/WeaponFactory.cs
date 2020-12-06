namespace _09_Refactoring.Core.Factories
{
    using Interfaces;
    using System;
    using Models.Weapons;

    public class WeaponFactory : IWeaponFactory
    {
        private IRarityFactory rarityFactory;

        public IWeapon CreateInstance
        (
            string typeName, string weaponName, string rarityType
        )
        {
            string weaponsNamespace = typeof(Weapon).Namespace;
            Type weaponType = Type.GetType($"{weaponsNamespace}.{typeName}");

            IRarity rarity = this.rarityFactory.CreateInstance(rarityType);
            object[] weaponArgs = new object[] { weaponName, rarity };

            IWeapon weapon =
                (IWeapon)Activator.CreateInstance(weaponType, weaponArgs);

            return weapon;
        }

        public WeaponFactory()
            : this(new RarityFactory())
        { }

        public WeaponFactory(IRarityFactory rarityFactory)
        {
            this.rarityFactory = rarityFactory;
        }
    }
}
