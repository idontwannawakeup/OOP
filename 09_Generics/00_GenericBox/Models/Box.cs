namespace _00_GenericBox.Models
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
