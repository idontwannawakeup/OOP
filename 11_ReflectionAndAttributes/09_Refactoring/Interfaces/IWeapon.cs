namespace _09_Refactoring.Interfaces
{
    public interface IWeapon
    {
        public string Name { get; }

        IRarity WeaponRarity { get; }

        int RawMinDamage { get; }

        int RawMaxDamage { get; }

        int ModifiedMinDamage { get; }

        int ModifiedMaxDamage { get; }

        string Info { get; }

        void AddGemInSocket(int index, IGem gem);

        void RemoveGemFromSocket(int index);
    }
}
