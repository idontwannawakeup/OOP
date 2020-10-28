using _07_FoodShortage.Models;
using System;

namespace _07_FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var city = new City();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ');
                if (info.Length == 4)
                {
                    city.AddNewCitizen(new Citizen(info[0], int.Parse(info[1]),
                                                   info[2], info[3]));
                }
                else if (info.Length == 3)
                {
                    city.AddNewFoodBuyer(new Rebel(info[0], int.Parse(info[1]), info[2]));
                }
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                city.MemberBuyFood(input);
                input = Console.ReadLine();
            }
            Console.WriteLine(city.TotalFoodAmount);

            Console.ReadKey();
        }
    }
}
