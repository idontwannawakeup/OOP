namespace _09_Refactoring.Interfaces
{
    public interface IWeaponFactory
    {
        IWeapon CreateInstance(string typeName, string weaponName, string rarityType);
    }
}
