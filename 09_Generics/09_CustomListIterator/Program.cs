using _09_CustomListIterator.Models;
using System;

namespace _09_CustomListIterator
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
                        foreach (var item in customList)
                            Console.WriteLine(item);
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
