namespace _04_BarracksWars_TheCommandsStrikeBack.Contracts
{
    public interface ICommandInterpreter
    {
        IExecutable InterpretCommand(string[] data, string commandName);
    }
}
