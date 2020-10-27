namespace _03_Ferrari
{
    class Ferrari : IPedals
    {
        public string Model { get; set; }
        public string Driver { get; set; }

        public string UseBrakes() => "Brakes!";
        public string PushGasPedal() => "Zadu6avamsA!";

        public Ferrari(string driver)
        {
            Model = "488-Spider";
            Driver = driver;
        }
    }
}
