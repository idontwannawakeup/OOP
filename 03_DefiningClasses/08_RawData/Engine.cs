namespace _08_RawData
{
    class Engine
    {
        public int Speed { get; private set; }
        public int Power { get; private set; }

        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
    }
}
