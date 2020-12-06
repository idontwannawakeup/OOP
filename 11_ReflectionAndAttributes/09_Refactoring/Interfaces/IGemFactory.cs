namespace _09_Refactoring.Interfaces
{
    public interface IGemFactory
    {
        IGem CreateInstance(string typeName, string clarityTypeName);
    }
}
