using System;
using System.Collections;
using System.Collections.Generic;

namespace _02_Collection.Models
{
    class ListyIterator<T> : IEnumerable<T>
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

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < data.Count; i++)
                yield return data[i];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public ListyIterator(List<T> data)
        {
            this.data = data;
            current = 0;
        }
    }
}
