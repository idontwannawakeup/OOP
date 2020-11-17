using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _09_LinkedListTraversal.Models
{
    class CustomLinkedList<T> : IEnumerable<T>
    {
        private Node<T> head = null;

        public int Count => CalculateCount();

        public T this[int index]
        {
            get => GetNodeByIndex(index).Value;
            set => GetNodeByIndex(index).Value = value;
        }

        public void Add(T item)
        {
            if (IsEmpty)
            {
                head = new Node<T>(item);
            }
            else
            {
                var newNode = new Node<T>(item);
                var currentLast = GetNodeByIndex(Count - 1);
                currentLast.Next = newNode;
                newNode.Prev = currentLast;
            }
        }

        public bool Remove(T item)
        {
            if (!IsEmpty && head.Value.Equals(item))
            {
                head = head.Next;
                head.Prev = null;
                return true;
            }

            for (var tmp = head.Next; tmp != null; tmp = tmp.Next)
                if (tmp.Value.Equals(item))
                {
                    var previous = tmp.Prev;
                    var next = tmp.Next;
                    previous.Next = next;
                    next.Prev = previous;

                    tmp.Next = null;
                    tmp.Prev = null;

                    return true;
                }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
                yield return this[i];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private bool IsEmpty => head == null;

        private int CalculateCount()
        {
            int count = 0;
            for (var tmp = head; tmp != null; tmp = tmp.Next, count++)
                continue;

            return count;
        }

        private Node<T> GetNodeByIndex(int index)
        {
            if (index < 0 || index >= Count || IsEmpty)
                throw new IndexOutOfRangeException();

            var result = head;
            for (int i = 0; i != index; i++, result = result.Next)
                continue;

            return result;
        }
    }
}
