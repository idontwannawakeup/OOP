namespace _10_Tuple.Models
{
    class CustomTuple<FirstT, SecondT>
    {
        public FirstT Item1 { get; set; }
        public SecondT Item2 { get; set; }

        public override string ToString() => $"{Item1} -> {Item2}";

        public CustomTuple(FirstT item1, SecondT item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }
}
