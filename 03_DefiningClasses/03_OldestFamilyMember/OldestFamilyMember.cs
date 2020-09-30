using System;

namespace _03_OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family goodFamily = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                goodFamily.AddMember(new Person(input[0], int.Parse(input[1])));
            }
            Person oldestMember = goodFamily.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");

            Console.ReadKey();
        }
    }
}
