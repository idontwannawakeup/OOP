using System;

namespace _05_PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string pizzaName = Console.ReadLine().Split(' ')[0];
                string[] doughInfo = Console.ReadLine().Replace('.', ',').Split(' ');
                var dough = new Dough(doughInfo[1], doughInfo[2],
                                      double.Parse(doughInfo[3]));

                var pizza = new Pizza(pizzaName, dough);

                string input = Console.ReadLine();
                while (input != "END")
                {
                    string[] info = input.Replace('.', ',').Split(' ');
                    pizza.AddTopping(new Topping(info[1], double.Parse(info[2])));

                    input = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:0.00} Calories.");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.ReadKey();
        }
    }
}
