namespace _09_Refactoring.Data
{
    using Interfaces;
    using System;
    using System.Collections.Generic;

    public class WeaponRepository : IWeaponRepository
    {
        private List<IWeapon> weapons;

        public void AddWeapon(IWeapon weapon)
        {
            this.weapons.Add(weapon);
        }

        public void AddGemInSocketOfWeapon(string weaponName, int index, IGem gem)
        {
            IWeapon weapon = this.weapons.Find(element => element.Name == weaponName);
            weapon?.AddGemInSocket(index, gem);
        }

        public void RemoveGemFromSocketOfWeapon(string weaponName, int index)
        {
            IWeapon weapon = this.weapons.Find(element => element.Name == weaponName);
            weapon?.RemoveGemFromSocket(index);
        }

        public string GetInfoAboutWeapon(string weaponName)
        {
            IWeapon weapon = this.weapons.Find(element => element.Name == weaponName);

            if (weapon == null)
                throw new ArgumentException("No such weapon in repository.");

            return weapon.Info;
        }

        public WeaponRepository()
        {
            this.weapons = new List<IWeapon>();
        }
    }
}
