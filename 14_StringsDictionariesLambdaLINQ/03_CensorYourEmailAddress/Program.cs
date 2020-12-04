using System;
using System.Text.RegularExpressions;

namespace _03_CensorYourEmailAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            string userEmail = Console.ReadLine();
            string input = Console.ReadLine();

            while (Regex.IsMatch(input, userEmail))
            {
                input = Regex.Replace(input, userEmail, (match) =>
                {
                    string[] partsOfEmail = match.Value.Split('@');
                    string username = partsOfEmail[0];
                    string host = partsOfEmail[1];

                    return $"{new string('*', username.Length)}@{host}";
                });
            }

            Console.WriteLine(input);

            Console.ReadKey();
        }
    }
}
