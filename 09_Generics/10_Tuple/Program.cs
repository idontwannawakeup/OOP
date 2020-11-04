using _10_Tuple.Models;
using System;

namespace _10_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            var firstTuple = new CustomTuple<string, string>
                (
                    firstLine[0] + " " + firstLine[1], firstLine[2]
                );

            string[] secondLine = Console.ReadLine().Split(' ');
            var secondTuple = new CustomTuple<string, int>
                (
                    secondLine[0],int.Parse(secondLine[1])
                );

            string[] thirdLine = Console.ReadLine().Replace('.', ',').Split(' ');
            var thirdTuple = new CustomTuple<int, double>
                (
                    int.Parse(thirdLine[0]), double.Parse(thirdLine[1])
                );

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);

            Console.ReadKey();
        }
    }
}
