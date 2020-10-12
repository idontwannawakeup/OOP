using System;
using System.Collections.Generic;

namespace _05_PizzaCalories
{
    class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings = new List<Topping>();

        public string Name
        {
            get => name;
            set
            {
                if (value == "" || value.Length > 15)
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");

                name = value;
            }
        }

        public int NumberOfToppings { get => toppings.Count; }

        public double TotalCalories { get => CalculateTotalCalories(); }

        public void AddTopping(Topping topping)
        {
            if (NumberOfToppings == 10)
                throw new Exception("Number of toppings should be in range [0..10].");

            toppings.Add(topping);
        }

        private double CalculateTotalCalories()
        {
            double result = dough.TotalCalories;

            foreach (var item in toppings)
                result += item.TotalCalories;

            return result;
        }

        public Pizza(string name, Dough dough)
        {
            Name = name;
            this.dough = dough;
        }
    }
}
