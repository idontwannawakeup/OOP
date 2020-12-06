﻿namespace _04_BarracksWars_TheCommandsStrikeBack
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
