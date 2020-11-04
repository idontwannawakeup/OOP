namespace _02_GenericBoxOfInteger.Models
{
    class Box<T>
    {
        public T Value { get; set; }

        public override string ToString() => $"{Value.GetType().FullName}: {Value}";

        public Box(T value)
        {
            Value = value;
        }
    }
}
