using System;
using System.Collections.Generic;

namespace _04_ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var persons = new List<Person>();
                string[] personsInfo = Console.ReadLine().Split(';');
                foreach (var item in personsInfo)
                    if (item != "")
                        persons.Add(Person.Parse(item.Replace('.', ',')));

                var products = new List<Product>();
                string[] productsInfo = Console.ReadLine().Split(';');
                foreach (var item in productsInfo)
                    if (item != "")
                        products.Add(Product.Parse(item.Replace('.', ',')));

                var outputs = new List<string>();
                string input = Console.ReadLine();
                while (input != "END")
                {
                    string[] info = input.Split(' ');
                    Person personFromInput = null;
                    foreach (var item in persons)
                        if (item.Name == info[0])
                            personFromInput = item;

                    Product productFromInput = null;
                    foreach (var item in products)
                        if (item.Name == info[1])
                            productFromInput = item;

                    outputs.Add(personFromInput.Buy(productFromInput));
                    input = Console.ReadLine();
                }

                foreach (var item in outputs)
                    Console.WriteLine(item);

                foreach (var item in persons)
                    Console.WriteLine(item.BoughtProducts);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.ReadKey();
        }
    }
}
