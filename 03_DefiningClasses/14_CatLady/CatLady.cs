using System;
using System.Collections.Generic;

namespace _14_CatLady
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Cat> cats = new List<Cat>();
            while (!input.Equals("End"))
            {
                string[] info = input.Split(' ');
                if (info[0].Equals("Siamese"))
                {
                    cats.Add(new Siamese(info[1], int.Parse(info[2])));
                }
                else if (info[0].Equals("Cymric"))
                {
                    cats.Add(new Cymric(info[1], double.Parse(info[2].Replace('.', ','))));
                }
                else if (info[0].Equals("StreetExtraordinaire"))
                {
                    cats.Add(new StreetExtraordinaire(info[1], int.Parse(info[2])));
                }
                input = Console.ReadLine();
            }

            string name = Console.ReadLine();
            foreach (var cat in cats)
            {
                if (cat.Name.Equals(name))
                {
                    Console.WriteLine(cat);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
