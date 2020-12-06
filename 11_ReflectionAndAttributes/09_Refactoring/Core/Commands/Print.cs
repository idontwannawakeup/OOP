namespace _09_Refactoring.Core.Commands
{
    using Interfaces;
    using System;

    class Print : Command
    {
        public override void Execute()
        {
            try
            {
                string weaponName = data[1];
                string info = this.repository.GetInfoAboutWeapon(weaponName);
                Console.WriteLine(info);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        public Print
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
