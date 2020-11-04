using _11_Threeuple.Models;
using System;

namespace _11_Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            var firstThreeuple = new CustomThreeuple<string, string, string>
                (
                    firstLine[0] + " " + firstLine[1], firstLine[2], firstLine[3]
                );

            string[] secondLine = Console.ReadLine().Split(' ');
            bool drunkOrNot = (secondLine[2] == "drunk") ? true : false;
            var secondThreeuple = new CustomThreeuple<string, int, bool>
                (
                    secondLine[0], int.Parse(secondLine[1]), drunkOrNot
                );

            string[] thirdLine = Console.ReadLine().Replace('.', ',').Split(' ');
            var thirdThreeuple = new CustomThreeuple<string, double, string>
                (
                    thirdLine[0], double.Parse(thirdLine[1]), thirdLine[2]
                );

            Console.WriteLine(firstThreeuple);
            Console.WriteLine(secondThreeuple);
            Console.WriteLine(thirdThreeuple);

            Console.ReadKey();
        }
    }
}
