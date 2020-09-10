using System;

namespace _03_Average
{
    class Average
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double average = (a + b + c) / 3.0;
            Console.WriteLine(average);

            Console.ReadKey();
        }
    }
}
