using _06_TrafficLights.Models;
using _06_TrafficLights.Factories;
using System;
using System.Collections.Generic;

namespace _06_TrafficLights
{
    class Program
    {
        static void Main(string[] args)
        {
            var trafficLightFactory = new TrafficLightFactory();
            var trafficLights = new List<TrafficLight>();

            string[] states = Console.ReadLine().Split(' ');
            foreach (string state in states)
            {
                try
                {
                    trafficLights.Add(trafficLightFactory.CreateTrafficLight(state));
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                trafficLights.ForEach(element => element.NextState());
                Console.WriteLine(string.Join(' ', trafficLights));
            }

            Console.ReadKey();
        }
    }
}
