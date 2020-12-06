namespace _09_Refactoring
{
    using Interfaces;
    using Core;
    using Core.Factories;
    using Data;

    class Program
    {
        static void Main(string[] args)
        {
            IWeaponFactory weaponFactory = new WeaponFactory();
            IGemFactory gemFactory = new GemFactory();

            IWeaponRepository repository = new WeaponRepository();
            ICommandInterpreter commandInterpreter = new CommandInterpreter
            (
                repository, weaponFactory, gemFactory
            );

            IRunnable engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
