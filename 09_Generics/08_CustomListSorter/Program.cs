using _08_CustomListSorter.Models;
using System;

namespace _08_CustomListSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            var customList = new CustomList<string>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] parameters = input.Split(' ');
                string command = parameters[0];

                switch (command)
                {
                    case "Add":
                        customList.Add(parameters[1]);
                        break;
                    case "Remove":
                        customList.Remove(int.Parse(parameters[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(customList.Contains(parameters[1]));
                        break;
                    case "Swap":
                        customList.Swap(int.Parse(parameters[1]),
                                        int.Parse(parameters[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(customList.CountGreaterThan(parameters[1]));
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;
                    case "Print":
                        for (int i = 0; i < customList.Count; i++)
                            Console.WriteLine(customList[i]);
                        break;
                    case "Sort":
                        Sorter.Sort(customList);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
