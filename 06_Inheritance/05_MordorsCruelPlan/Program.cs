using _05_MordorsCruelPlan.Factories;
using _05_MordorsCruelPlan.FoodModels;
using System;
using System.Collections.Generic;

namespace _05_MordorsCruelPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            var food = new List<Food>();
            string[] input = Console.ReadLine().Split(' ');

            foreach (var item in input)
                food.Add(FoodFactory.MakeFood(item));

            int pointsOfHappiness = 0;
            foreach (var item in food)
                pointsOfHappiness += item.Points;

            var gendalfMood = MoodFactory.MakeMood(pointsOfHappiness);
            Console.WriteLine(pointsOfHappiness);
            Console.WriteLine(gendalfMood.Name);

            Console.ReadKey();
        }
    }
}
