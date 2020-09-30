using System;

namespace _07_SpeedRacing
{
    class Car
    {
        public string Model { get; private set; }
        public double FuelAmount { get; private set; }
        public double FuelConsumption { get; private set; }
        public double DistanceTravelled { get; private set; }

        public void Drive(double distance)
        {
            double usedFuel = FuelConsumption * distance;
            if (FuelAmount - usedFuel < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                FuelAmount -= usedFuel;
                DistanceTravelled += distance;
            }
        }

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
            DistanceTravelled = 0;
        }
    }
}
