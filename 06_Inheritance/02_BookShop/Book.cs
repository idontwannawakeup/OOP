using System;
using System.Text;

namespace _02_BookShop
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public string Author
        {
            get => author;
            protected set
            {
                if (char.IsDigit(value.Split(' ')[1][0]))
                    throw new ArgumentException("Author not valid!");

                author = value;
            }
        }

        public string Title
        {
            get => title;
            protected set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Title not valid!");

                title = value;
            }
        }

        public virtual decimal Price
        {
            get => price;
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Price not valid!");

                price = value;
            }
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {GetType().Name}")
                         .AppendLine($"Title: {Title}")
                         .AppendLine($"Author: {Author}")
                         .AppendLine($"Price: {Price:f2}");

            return resultBuilder.ToString().TrimEnd();
        }

        public Book(string author, string title, decimal price)
        {
            Author = author;
            Title = title;
            Price = price;
        }
    }
}
