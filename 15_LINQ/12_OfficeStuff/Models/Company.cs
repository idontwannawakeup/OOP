namespace _12_OfficeStuff.Models
{
    class Company
    {
        public string Name { get; }
        public Product OrderedProduct { get; }

        public Company(string name, string amount, string product)
            : this(name, new Product(product, amount))
        { }

        public Company(string name, Product orderedProduct)
        {
            Name = name;
            OrderedProduct = orderedProduct;
        }
    }
}
