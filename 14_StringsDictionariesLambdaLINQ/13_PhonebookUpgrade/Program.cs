using System;
using System.Collections.Generic;

namespace _13_PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var info = input.Split(' ');

                switch (info[0])
                {
                    case "A":
                        phonebook[info[1]] = info[2];
                        break;
                    case "S":
                        if (phonebook.ContainsKey(info[1]))
                            Console.WriteLine($"{info[1]} -> {phonebook[info[1]]}");
                        else
                            Console.WriteLine($"Contact {info[1]} does not exist.");
                        break;
                    case "ListAll":
                        foreach (var (key, value) in phonebook)
                            Console.WriteLine($"{key} -> {value}");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
