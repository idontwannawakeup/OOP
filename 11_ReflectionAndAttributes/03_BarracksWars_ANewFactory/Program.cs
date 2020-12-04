namespace _03_BarracksWars_ANewFactory
{
    using Contracts;
    using Core;
    using Core.Factories;
    using Data;

    class Program
    {
        static void Main(string[] args)
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            IRunnable engine = new Engine(repository, unitFactory);
            engine.Run();
        }
    }
}
