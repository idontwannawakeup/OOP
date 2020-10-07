namespace _03_JediGalaxy
{
    struct Coordinates
    {
        public int x;
        public int y;

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    abstract class Jedi
    {
        protected Coordinates position;
        public int Score { get; set; }

        public void UpdateCoordinates(int x, int y)
        {
            position = new Coordinates(x, y);
        }

        abstract public void Shoot(Galaxy galaxy);

        public Jedi()
            : this(0, 0) { }

        public Jedi(int x, int y)
        {
            position = new Coordinates(x, y);
            Score = 0;
        }
    }
}
