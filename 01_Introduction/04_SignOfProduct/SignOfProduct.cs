using System;

namespace _04_SignOfProduct
{
    class SignOfProduct
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            bool isPositiveA = a >= 0;
            bool isPositiveB = b >= 0;
            bool isPositiveC = c >= 0;
            
            bool isProductPositive = (isPositiveA  && isPositiveB  && isPositiveC) ||
                                     (!isPositiveA && !isPositiveB && isPositiveC) ||
                                     (!isPositiveB && !isPositiveC && isPositiveA) ||
                                     (!isPositiveA && !isPositiveC && isPositiveB);

            if (isProductPositive)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }

            Console.ReadKey();
        }
    }
}
