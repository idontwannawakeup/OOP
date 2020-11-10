using _12_OfficeStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_OfficeStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new List<Company>();
            byte n = byte.Parse(Console.ReadLine());
            for (byte i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Replace("|", "").Split(" - ");
                companies.Add(new Company(info[0], info[1], info[2]));
            }

            var groupedCompanies = companies.GroupBy(element => element.Name);
            foreach (var item in groupedCompanies)
            {
                var products = item.GroupBy(element => element.OrderedProduct.Name)
                                   .Select(x => new Product(x.Key, x.Sum(e => e.OrderedProduct.Amount)))
                                   .ToList();

                Console.WriteLine($"{item.Key}: {string.Join(", ", products)}");
            }

            Console.ReadKey();
        }
    }
}
