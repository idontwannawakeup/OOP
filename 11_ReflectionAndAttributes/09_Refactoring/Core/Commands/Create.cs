namespace _09_Refactoring.Core.Commands
{
    using Interfaces;

    class Create : Command
    {
        public override void Execute()
        {
            string[] weaponInfo = data[1].Split(' ');

            string weaponTypeName = weaponInfo[1];
            string weaponName = data[2];
            string rarityType = weaponInfo[0];

            IWeapon weapon = this.weaponFactory.CreateInstance(weaponTypeName, weaponName, rarityType);
            this.repository.AddWeapon(weapon);
        }

        public Create
        (
            string[] data,
            IWeaponRepository repository,
            IWeaponFactory weaponFactory,
            IGemFactory gemFactory
        )
            : base(data, repository, weaponFactory, gemFactory)
        { }
    }
}
