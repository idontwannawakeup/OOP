namespace _06_Animals.Animals
{
    class Dog : Animal
    {
        public override string ProduceSound() => "Woof!";

        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        { }
    }
}
