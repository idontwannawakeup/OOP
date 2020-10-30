using _05_BorderControl.Models;
using System;

namespace _05_BorderControl
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
                if (info.Length == 3)
                    city.AddNewIdentifiable(new Citizen(info[0], int.Parse(info[1]), info[2]));
                else if (info.Length == 2)
                    city.AddNewIdentifiable(new Robot(info[0], info[1]));

                input = Console.ReadLine();
            }

            string fakeId = Console.ReadLine();
            var membersWithFakeId = city.DetectMembersWithFakeId(fakeId);
            foreach (var item in membersWithFakeId)
                Console.WriteLine(item.Id);

            Console.ReadKey();
        }
    }
}
