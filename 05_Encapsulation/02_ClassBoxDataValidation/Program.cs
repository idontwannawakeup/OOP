﻿using System;

namespace _02_ClassBoxDataValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine().Replace('.', ','));
            double width = double.Parse(Console.ReadLine().Replace('.', ','));
            double height = double.Parse(Console.ReadLine().Replace('.', ','));

            try
            {
                Box box = new Box(length, width, height);
                Console.WriteLine($"Surface Area – {box.SurfaceArea():0.00}");
                Console.WriteLine($"Lateral Surface Area – {box.LateralSurfaceArea():0.00}");
                Console.WriteLine($"Volume - {box.Volume():0.00}");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.ReadKey();
        }
    }
}
