namespace _10_ExplicitInterfaces.Interfaces
{
    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }

        string GetName();
    }
}
