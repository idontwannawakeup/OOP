using System.Collections;
using System.Collections.Generic;

namespace _09_CustomListIterator.Models
{
    class ListNumerator<T> : IEnumerator<T>
    {
        private Node<T> startingNode;
        private Node<T> currentNode;

        public void AddHead(Node<T> head)
        {
            startingNode.Next = head;
        }

        public T Current => currentNode.Value;

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            currentNode = startingNode;
        }

        public void Dispose()
        {
        }

        public ListNumerator()
        {
            startingNode = new Node<T>(default(T));
            currentNode = startingNode;
        }
    }
}
