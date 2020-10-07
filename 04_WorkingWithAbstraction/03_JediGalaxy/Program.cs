using System;

namespace _03_JediGalaxy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            Galaxy galaxy = new Galaxy(dimensions);
            GoodSideJedi ivy = new GoodSideJedi();
            EvilSideJedi evilForce = new EvilSideJedi();

            string command = Console.ReadLine();
            while (!command.Equals("Let the Force be with you"))
            {
                string[] ivyCoords = command.Split(' ');
                string[] evilForcesCoords = Console.ReadLine().Split(' ');

                ivy.UpdateCoordinates(int.Parse(ivyCoords[0]) - 1,
                                      int.Parse(ivyCoords[1]) + 1);
                evilForce.UpdateCoordinates(int.Parse(evilForcesCoords[0]) - 1,
                                            int.Parse(evilForcesCoords[1]) - 1);
                evilForce.Shoot(galaxy);
                ivy.Shoot(galaxy);

                command = Console.ReadLine();
            }

            Console.WriteLine(ivy.Score);

            Console.ReadKey();
        }
    }
}
