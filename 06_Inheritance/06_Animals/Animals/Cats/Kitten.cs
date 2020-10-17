namespace _06_Animals.Animals.Cats
{
    class Kitten : Cat
    {
        public override string ProduceSound() => "Meow";

        public Kitten(string name, int age)
            : base(name, age, "Female")
        { }
    }
}
