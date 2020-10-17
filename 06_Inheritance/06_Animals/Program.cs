using _06_Animals.Animals;
using _06_Animals.Animals.Cats;
using System;
using System.Collections.Generic;

namespace _06_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var animals = new List<Animal>();

            while (input != "Beast!")
            {
                string type = input;
                string[] info = Console.ReadLine().Split(' ');

                try
                {
                    switch (type)
                    {
                        case "Dog":
                            animals.Add(new Dog(info[0], int.Parse(info[1]), info[2]));
                            break;
                        case "Frog":
                            animals.Add(new Frog(info[0], int.Parse(info[1]), info[2]));
                            break;
                        case "Cat":
                            animals.Add(new Cat(info[0], int.Parse(info[1]), info[2]));
                            break;
                        case "Kitten":
                            animals.Add(new Kitten(info[0], int.Parse(info[1])));
                            break;
                        case "Tomcat":
                            animals.Add(new Tomcat(info[0], int.Parse(info[1])));
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                input = Console.ReadLine();
            }

            foreach (var item in animals)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
