namespace _09_Refactoring.Core.Commands
{
    using Interfaces;

    class Add : Command
    {
        public override void Execute()
        {
            string[] gemInfo = data[3].Split(' ');

            string weaponName = data[1];
            int socketIndex = int.Parse(data[2]);
            string typeName = gemInfo[1];
            string clarityTypeName = gemInfo[0];

            IGem gem = this.gemFactory.CreateInstance(typeName, clarityTypeName);
            this.repository.AddGemInSocketOfWeapon(weaponName, socketIndex, gem);
        }

        public Add
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
