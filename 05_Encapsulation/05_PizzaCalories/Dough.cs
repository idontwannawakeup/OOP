using System;

namespace _05_PizzaCalories
{
    class Dough
    {
        private string flour;
        private string bakingTechnique;
        private double weight;

        public string Flour
        {
            get => flour;
            set
            {
                if (value != "White" && value != "Wholegrain")
                    throw new Exception("Invalid type of dough.");

                flour = value;
            }
        }

        public string BakingTechnique
        {
            get => bakingTechnique;
            set
            {
                if (value != "Crispy" && value != "Chewy" && value != "Homemade")
                    throw new Exception("Invalid type of dough.");

                bakingTechnique = value;
            }
        }

        public double Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 200)
                    throw new Exception("Dough weight should be in the range [1..200].");

                weight = value;
            }
        }

        public double CaloriesPerGram
        {
            get => CalculateCaloriesPerGram();
        }

        public double TotalCalories { get => CaloriesPerGram * weight; }

        private double CalculateCaloriesPerGram()
        {
            double basicModifier  =  2;
            double flourModifier  =  (Flour == "White") ? 1.5 : 1.0;
            double bakingModifier =  (BakingTechnique == "Crispy") ? 0.9 :
                                     (BakingTechnique == "Chewy")  ? 1.1 : 1.0;

            return basicModifier * flourModifier * bakingModifier;
        }

        public Dough(string flour, string bakingTechnique, double weight)
        {
            Flour = flour;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }
    }
}
