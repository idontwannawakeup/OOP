namespace _06_Animals.Animals.Cats
{
    class Cat : Animal
    {
        public override string ProduceSound() => "Meow meow";

        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        { }
    }
}
