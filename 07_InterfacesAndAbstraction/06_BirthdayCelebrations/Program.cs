using System;

namespace _06_BirthdayCelebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = new City();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] info = input.Split(' ');
                switch (info[0])
                {
                    case "Citizen":
                        city.AddNewCitizen(new Citizen(info[1], int.Parse(info[2]),
                                                       info[3], info[4]));
                        break;
                    case "Robot":
                        city.AddNewIdentifiable(new Robot(info[1], info[2]));
                        break;
                    case "Pet":
                        city.AddNewBirthable(new Pet(info[1], info[2]));
                        break;
                }

                input = Console.ReadLine();
            }

            int year = int.Parse(Console.ReadLine());
            var members = city.GetMembersWithSameBirthYear(year);
            foreach (var item in members)
                Console.WriteLine($"{item.Birthdate:dd}/" +
                                  $"{item.Birthdate:MM}/" +
                                  $"{item.Birthdate:yyyy}");

            Console.ReadKey();
        }
    }
}
