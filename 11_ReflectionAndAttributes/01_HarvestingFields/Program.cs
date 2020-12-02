using _01_HarvestingFields.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _01_HarvestingFields
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "HARVEST")
            {
                var fields = input switch
                {
                    "private" => typeof(HarvestingFields)
                        .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                        .Where(x => x.IsPrivate)
                        .ToList(),

                    "public" => typeof(HarvestingFields)
                        .GetFields()
                        .ToList(),

                    "protected" => typeof(HarvestingFields)
                        .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                        .Where(x => !x.IsPrivate)
                        .ToList(),

                    "all" => typeof(HarvestingFields)
                        .GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                        .ToList(),

                    _ => null
                };

                fields?.ForEach(element =>
                {
                    string modifier = element.IsPublic ? "public"
                        : element.IsPrivate ? "private" : "protected";

                    Console.WriteLine($"{modifier} {element.FieldType.Name} {element.Name}");
                });
            }

            Console.ReadKey();
        }
    }
}
