using System;

namespace _06_GenericCountMethodDoubles.Models
{
    class Box<T> : IComparable<Box<T>>
        where T : IComparable<T>
    {
        public T Value { get; set; }

        public override string ToString() => $"{Value.GetType().FullName}: {Value}";

        public int CompareTo(Box<T> other) => Value.CompareTo(other.Value);

        public Box(T value)
        {
            Value = value;
        }
    }
}
