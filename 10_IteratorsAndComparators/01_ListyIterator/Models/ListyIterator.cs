using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ListyIterator.Models
{
    class ListyIterator<T>
    {
        private List<T> data;
        private int current;

        public bool Move()
        {
            if (HasNext())
            {
                current++;
                return true;
            }

            return false;
        }

        public bool HasNext() => (current < data.Count - 1);

        public void Print()
        {
            if (data.Count == 0)
                throw new InvalidOperationException("Invalid operation!");

            Console.WriteLine(data[current]);
        }

        public ListyIterator(List<T> data)
        {
            this.data = data;
            current = 0;
        }
    }
}
