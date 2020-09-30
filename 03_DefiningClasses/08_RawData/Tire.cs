namespace _08_RawData
{
    class Tire
    {
        public double Pressure { get; private set; }
        public int Age { get; private set; }

        public Tire(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }
    }
}
