namespace _09_Refactoring.Core
{
    using Interfaces;
    using Core.Commands;
    using System;

    public class CommandInterpreter : ICommandInterpreter
    {
        private IWeaponRepository repository;

        private IWeaponFactory weaponFactory;

        private IGemFactory gemFactory;

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            try
            {
                string commandsNamespace = typeof(Command).Namespace;

                Type commandType = Type.GetType($"{commandsNamespace}.{commandName}");
                object[] commandArgs = new object[]
                {
                    data, repository, weaponFactory, gemFactory
                };

                IExecutable command =
                    (IExecutable)Activator.CreateInstance(commandType, commandArgs);

                return command;
            }
            catch
            {
                throw new ArgumentException("Invalid command!");
            }
        }

        public CommandInterpreter
        (
            IWeaponRepository repository,
            IWeaponFactory weaponFactory,
            IGemFactory gemFactory
        )
        {
            this.repository = repository;
            this.weaponFactory = weaponFactory;
            this.gemFactory = gemFactory;
        }
    }
}
