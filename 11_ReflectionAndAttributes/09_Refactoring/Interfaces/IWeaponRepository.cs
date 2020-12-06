namespace _09_Refactoring.Interfaces
{
    public interface IWeaponRepository
    {
        void AddWeapon(IWeapon weapon);

        void AddGemInSocketOfWeapon(string weaponName, int index, IGem gem);

        void RemoveGemFromSocketOfWeapon(string weaponName, int index);

        string GetInfoAboutWeapon(string weaponName);
    }
}
