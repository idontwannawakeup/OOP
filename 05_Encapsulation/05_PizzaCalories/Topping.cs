using System;

namespace _05_PizzaCalories
{
    class Topping
    {
        private string type;
        private double weight;

        public string Type
        {
            get => type;
            set
            {
                if (value != "Meat"   && value != "Veggies" &&
                    value != "Cheese" && value != "Sauce")
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }
                    
                type = value;
            }
        }

        public double Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 50)
                    throw new Exception($"{Type} weight should be in the range [1..50].");

                weight = value;
            }
        }

        public double CaloriesPerGram { get => CalculateCaloriesPerGram(); }

        public double TotalCalories { get => CaloriesPerGram * weight; }

        private double CalculateCaloriesPerGram()
        {
            double basicModifier = 2;
            double typeModifier = (Type == "Meat")    ? 1.2 :
                                  (Type == "Veggies") ? 0.8 :
                                  (Type == "Cheese")  ? 1.1 : 0.9;

            return basicModifier * typeModifier;
        }

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }
    }
}
