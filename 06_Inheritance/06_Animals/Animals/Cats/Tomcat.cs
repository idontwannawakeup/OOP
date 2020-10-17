namespace _06_Animals.Animals.Cats
{
    class Tomcat : Cat
    {
        public override string ProduceSound() => "MEOW";

        public Tomcat(string name, int age)
            : base(name, age, "Male")
        { }
    }
}
