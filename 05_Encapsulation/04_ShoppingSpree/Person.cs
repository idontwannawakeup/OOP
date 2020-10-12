using System;
using System.Collections.Generic;

namespace _04_ShoppingSpree
{
    class Person
    {
        private string name;
        private double money;
        private List<Product> bagOfProducts = new List<Product>();

        public string Name
        {
            get => name;
            set
            {
                if (value == null || value == "")
                    throw new Exception("Name cannot be empty.");

                name = value;
            }
        }

        public double Money
        {
            get => money;
            set
            {
                if (value < 0)
                    throw new Exception("Money cannot be negative.");

                money = value;
            }
        }

        public string BoughtProducts { get => GetBoughtProducts(); }

        public string Buy(Product product)
        {
            if (Money < product.Cost)
                return $"{Name} can't afford {product.Name}";

            Money -= product.Cost;
            bagOfProducts.Add(product);
            return $"{Name} bought {product.Name}";
        }

        private string GetBoughtProducts()
        {
            string boughtProducts = $"{Name} - ";
            if (bagOfProducts.Count == 0)
                return boughtProducts + "Nothing bought";

            bool first = true;
            foreach (var item in bagOfProducts)
            {
                if (!first)
                    boughtProducts += ", ";

                boughtProducts += item.Name;
                first = false;
            }

            return boughtProducts;
        }

        public static Person Parse(string input)
        {
            string[] info = input.Split('=');
            return new Person(info[0], double.Parse(info[1]));
        }

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
        }
    }
}
