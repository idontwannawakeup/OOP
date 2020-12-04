using System;
using System.Collections.Generic;

namespace _12_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();

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
                }
            }

            Console.ReadKey();
        }
    }
}
