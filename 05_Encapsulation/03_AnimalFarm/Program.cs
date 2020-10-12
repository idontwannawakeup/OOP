using System;

namespace _03_AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            string chickenName = Console.ReadLine();
            int chickenAge = int.Parse(Console.ReadLine());

            try
            {
                var chicken = new Chicken(chickenName, chickenAge);
                Console.WriteLine($"Chicken {chicken.Name} (age {chicken.Age}) " +
                                  $"can produce {chicken.ProductPerDay} eggs per day.");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.ReadKey();
        }
    }
}
