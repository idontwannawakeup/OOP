using System;

namespace _03_AnimalFarm
{
    class Chicken
    {
        private string name;
        private int age;

        public string Name
        {
            get => name;
            set
            {
                if (value == null || value == "" || value == " ")
                    throw new Exception("Name cannot be empty.");

                name = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 0 || value > 15)
                    throw new Exception("Age should be between 0 and 15.");

                age = value;
            }
        }

        public int ProductPerDay { get => CalculateProductPerDay(); }

        private int CalculateProductPerDay()
        {
            return Age / 10;
        }

        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
