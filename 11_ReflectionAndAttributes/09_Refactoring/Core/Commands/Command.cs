namespace _09_Refactoring.Core.Commands
{
    using Interfaces;

    public abstract class Command : IExecutable
    {
        protected string[] data;

        protected IWeaponRepository repository;

        protected IWeaponFactory weaponFactory;

        protected IGemFactory gemFactory;

        public abstract void Execute();

        protected Command
        (
            string[] data,
            IWeaponRepository repository,
            IWeaponFactory weaponFactory,
            IGemFactory gemFactory
        )
        {
            this.data = data;
            this.repository = repository;
            this.weaponFactory = weaponFactory;
            this.gemFactory = gemFactory;
        }
    }
}
