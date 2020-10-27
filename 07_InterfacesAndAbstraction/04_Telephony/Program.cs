using System;

namespace _04_Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone = new Smartphone();
            var phoneNumbers = Console.ReadLine().Split(' ');
            var urls = Console.ReadLine().Split(' ');

            foreach (var item in phoneNumbers)
            {
                try
                {
                    phone.Call(item);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            foreach (var item in urls)
            {
                try
                {
                    phone.Browse(item);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
