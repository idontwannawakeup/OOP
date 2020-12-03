using _02_BlackBoxInteger.Models;
using System;
using System.Reflection;

namespace _02_BlackBoxInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = (BlackBoxInteger)Activator.CreateInstance(typeof(BlackBoxInteger), true);

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    var info = input.Split('_');
                    if (info.Length != 2)
                        throw new Exception("Wrong input line!");

                    var method = typeof(BlackBoxInteger)
                        .GetMethod(info[0], BindingFlags.NonPublic | BindingFlags.Instance);

                    method?.Invoke(box, new object[] { int.Parse(info[1]) });

                    var boxValue = (int)typeof(BlackBoxInteger)
                        .GetField("innerValue", BindingFlags.NonPublic| BindingFlags.Instance)
                        .GetValue(box);

                    Console.WriteLine(boxValue);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
