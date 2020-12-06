namespace _09_Refactoring.Interfaces
{
    public interface IRarityFactory
    {
        IRarity CreateInstance(string typeName);
    }
}
