using System;

namespace _02_Animals.Models
{
    class Dog : Animal
    {
        public override string ExplainSelf()
            => base.ExplainSelf() + Environment.NewLine + "DJAAF";

        public Dog(string name, string favouriteFood)
            : base(name, favouriteFood)
        { }
    }
}
