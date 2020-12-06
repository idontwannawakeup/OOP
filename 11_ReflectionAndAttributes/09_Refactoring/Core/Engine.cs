namespace _09_Refactoring.Core
{
    using Interfaces;
    using System;

    public class Engine : IRunnable
    {
        private ICommandInterpreter commandInterpreter;

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    if (input == "END")
                        Environment.Exit(0);

                    string[] data = input.Split(';');
                    string commandName = data[0];

                    IExecutable command =
                        this.commandInterpreter.InterpretCommand(data, commandName);

                    command.Execute();
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }
    }
}
