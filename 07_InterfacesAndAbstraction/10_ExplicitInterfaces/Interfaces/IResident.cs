namespace _10_ExplicitInterfaces.Interfaces
{
    interface IResident
    {
        string Name { get; set; }
        string Country { get; set; }

        string GetName();
    }
}
