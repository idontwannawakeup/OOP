namespace _04_BarracksWars_TheCommandsStrikeBack.Core
{
    using System;
    using Contracts;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private string InterpredCommand(string[] data, string commandName)
        {
            try
            {
                string capitalizedCommandName =
                    char.ToUpper(commandName[0]) + commandName.Substring(1);

                string unitsNamespace =
                    "_04_BarracksWars_TheCommandsStrikeBack.Core.Commands";

                string fullCommandName = $"{unitsNamespace}.{capitalizedCommandName}";

                Type commandType = Type.GetType(fullCommandName);
                object[] commandArgs = new object[] { data, repository, unitFactory };

                IExecutable command =
                    (IExecutable)Activator.CreateInstance(commandType, commandArgs);

                return command.Execute();
            }
            catch
            {
                throw new InvalidOperationException("Invalid command!");
            }
        }
    }
}
