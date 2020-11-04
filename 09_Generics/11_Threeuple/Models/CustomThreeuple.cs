namespace _11_Threeuple.Models
{
    class CustomThreeuple<FirstT, SecondT, ThirdT> : CustomTuple<FirstT, SecondT>
    {
        public ThirdT Item3 { get; set; }

        public override string ToString() => base.ToString() + $" -> {Item3}";

        public CustomThreeuple(FirstT item1, SecondT item2, ThirdT item3)
            : base(item1, item2)
        {
            Item3 = item3;
        }
    }
}
