
using System;

namespace _11_CommonStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            bool check = false;
            foreach (var item in first)
                if (second.Contains(item))
                {
                    check = true;
                    break;
                }

            var result = check ? "yes" : "no";
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
