namespace _12_OfficeStuff.Models
{
    class Product
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public override string ToString() => $"{Name}-{Amount}";

        public Product(string name, string amount)
            : this(name, int.Parse(amount))
        { }

        public Product(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
