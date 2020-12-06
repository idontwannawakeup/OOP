namespace _09_Refactoring.Core.Commands
{
    using Interfaces;

    class Remove : Command
    {
        public override void Execute()
        {
            string weaponName = data[1];
            int socketIndex = int.Parse(data[2]);

            this.repository.RemoveGemFromSocketOfWeapon(weaponName, socketIndex);
        }

        public Remove
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
