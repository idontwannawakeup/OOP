using System;
using System.Collections;
using System.Collections.Generic;

namespace _09_CustomListIterator.Models
{
    class CustomList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        delegate bool Predicate(Node<T> currentLast, Node<T> nextElement);

        private ListNumerator<T> enumerator = new ListNumerator<T>();
        private Node<T> head = null;

        public T this[int index]
        {
            get => GetNodeByIndex(index).Value;
            set => GetNodeByIndex(index).Value = value;
        }

        public int Count => CalculateCount();

        public bool IsEmpty => head == null;

        public void Add(T item)
        {
            if (IsEmpty)
                UpdateHead(item);
            else
                GetNodeByIndex(Count - 1).Next = new Node<T>(item);
        }

        public T Remove(int index)
        {
            if (index == 0 && !IsEmpty)
                return RemoveHead();

            var nodeBeforeRemovable = GetNodeByIndex(index - 1);
            var nodeToRemove = nodeBeforeRemovable.Next;
            nodeBeforeRemovable.Next = nodeToRemove.Next;
            return nodeToRemove.Value;
        }

        public bool Contains(T element)
        {
            for (var tmp = head; tmp != null; tmp = tmp.Next)
                if (tmp.Value.Equals(element))
                    return true;

            return false;
        }

        public void Swap(int index1, int index2)
        {
            var lhsNode = GetNodeByIndex(index1);
            var rhsNode = GetNodeByIndex(index2);

            T tmp = lhsNode.Value;
            lhsNode.Value = rhsNode.Value;
            rhsNode.Value = tmp;
        }

        public int CountGreaterThan(T element)
        {
            int count = 0;
            for (var tmp = head; tmp != null; tmp = tmp.Next)
                if (tmp.Value.CompareTo(element) > 0)
                    count++;

            return count;
        }

        public T Max()
        {
            return FindLastThatMatchesPredicate(
                (currentLast, nextElement)
                    => currentLast.Value.CompareTo(nextElement.Value) < 0
            );
        }

        public T Min()
        {
            return FindLastThatMatchesPredicate(
                (currentLast, nextElement)
                    => currentLast.Value.CompareTo(nextElement.Value) > 0
            );
        }

        public IEnumerator<T> GetEnumerator() => enumerator;

        IEnumerator IEnumerable.GetEnumerator() => enumerator;

        private void UpdateHead(T item)
        {
            head = new Node<T>(item);
            enumerator.AddHead(head);
        }

        private T RemoveHead()
        {
            var currentFirst = head;
            head = head.Next;
            return currentFirst.Value;
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

        private int CalculateCount()
        {
            int count = 0;
            for (var tmp = head; tmp != null; tmp = tmp.Next, count++)
                continue;

            return count;
        }

        private T FindLastThatMatchesPredicate(Predicate predicate)
        {
            var result = head;
            for (var tmp = head; tmp != null; tmp = tmp.Next)
                if (predicate(result, tmp))
                    result = tmp;

            return result.Value;
        }
    }
}
