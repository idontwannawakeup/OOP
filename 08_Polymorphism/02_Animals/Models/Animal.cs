namespace _02_Animals.Models
{
    class Animal
    {
        private string name;
        private string favouriteFood;

        public virtual string ExplainSelf()
            => $"I am {name} and my favourite food is {favouriteFood}";

        public Animal(string name, string favouriteFood)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }
    }
}
