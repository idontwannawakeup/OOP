using System;

namespace _04_NumberAsDayOfWeek
{
    class NumberAsDayOfWeek
    {
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("not valid");
                        break;
                }
            }
            else
            {
                Console.WriteLine("not valid");
            }

            Console.ReadKey();
        }
    }
}
