namespace _09_Refactoring.Interfaces
{
    public interface IClarityFactory
    {
        IClarity CreateInstance(string typeName);
    }
}
