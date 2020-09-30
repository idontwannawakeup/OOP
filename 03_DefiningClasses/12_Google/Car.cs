namespace _12_Google
{
    class Car
    {
        public string Model { get; }
        public int Speed { get; }

        public override string ToString()
        {
            return new string($"{Model} {Speed}\n");
        }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
    }
}
