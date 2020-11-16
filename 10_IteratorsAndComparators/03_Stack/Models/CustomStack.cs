using System;
using System.Collections;
using System.Collections.Generic;

namespace _03_Stack.Models
{
    class CustomStack<T> : IEnumerable<T>
    {
        private List<T> data = new List<T>();

        public void Push(T item)
        {
            data.Add(item);
        }

        public void Push(IEnumerable<T> items)
        {
            data.AddRange(items);
        }

        public T Pop()
        {
            if (data.Count == 0)
                throw new ArgumentException("No elements!");

            var result = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = data.Count - 1; i >= 0; i--)
                yield return data[i];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
