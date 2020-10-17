namespace _06_Animals.Animals
{
    class Frog : Animal
    {
        public override string ProduceSound() => "Ribbit";

        public Frog(string name, int age, string gender)
            : base(name, age, gender)
        { }
    }
}
