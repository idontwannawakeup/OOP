namespace _02_BookShop
{
    class GoldenEditionBook : Book
    {
        public override decimal Price { get => base.Price * 1.3M; }

        public GoldenEditionBook(string author, string title, decimal price)
            : base(author, title, price)
        { }
    }
}
