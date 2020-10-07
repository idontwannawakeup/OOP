using System;

namespace _04_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();
            string input = Console.ReadLine();
            while (!input.Equals("Output"))
            {
                string[] info = input.Split(' ');
                hospital.UpdateInfo(info[0], info[1] + " " + info[2], info[3]);
                input = Console.ReadLine();
            }

            string output = Console.ReadLine();
            while (!output.Equals("End"))
            {
                hospital.PrintInfo(output);
                output = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
