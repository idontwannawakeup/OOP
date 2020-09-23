using System;
using System.Collections.Generic;

namespace _14_CatLady
{
    class Program
    {
        class Cat
        {
            public string Name { get; protected set; }
        }

        class Siamese : Cat
        {
            public int Earsize { get; }

            public override string ToString()
            {
                return new string($"{typeof(Siamese).Name} {Name} {Earsize}");
            }

            public Siamese(string name, int earsize)
            {
                Name = name;
                Earsize = earsize;
            }
        }

        class Cymric : Cat
        {
            public double FurLength { get; }

            public override string ToString()
            {
                return new string($"{typeof(Cymric).Name} {Name} {FurLength:0.00}");
            }

            public Cymric(string name, double furLength)
            {
                Name = name;
                FurLength = furLength;
            }
        }

        class StreetExtraordinaire : Cat
        {
            public int DecibelsOfMeows { get; }

            public override string ToString()
            {
                return new string($"{typeof(StreetExtraordinaire).Name} {Name} {DecibelsOfMeows}");
            }

            public StreetExtraordinaire(string name, int decibelsOfMeows)
            {
                Name = name;
                DecibelsOfMeows = decibelsOfMeows;
            }
        }

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
