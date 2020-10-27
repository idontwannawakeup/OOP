using System;

namespace _04_Telephony
{
    class Smartphone : ICallable, IBrowseable
    {
        public void Call(string phoneNumber)
        {
            foreach (var item in phoneNumber)
                if (!char.IsDigit(item))
                    throw new ArgumentException("Invalid number!");

            Console.WriteLine($"Calling... {phoneNumber}");
        }

        public void Browse(string url)
        {
            foreach (var item in url)
                if (char.IsDigit(item))
                    throw new ArgumentException("Invalid URL!");

            Console.WriteLine($"Browsing: {url}!");
        }
    }
}
