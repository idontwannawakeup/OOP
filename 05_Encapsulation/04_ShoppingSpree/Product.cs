using System;

namespace _04_ShoppingSpree
{
    class Product
    {
        private string name;
        private double cost;

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

        public double Cost
        {
            get => cost;
            set
            {
                if (value < 0)
                    throw new Exception("Cost cannot be negative.");

                cost = value;
            }
        }

        public static Product Parse(string input)
        {
            string[] info = input.Split('=');
            return new Product(info[0], double.Parse(info[1]));
        }

        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
