﻿namespace _01_RawData
{
    class Tire
    {
        public double Pressure { get; }
        public int Age { get; }

        public Tire(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }
    }
}
