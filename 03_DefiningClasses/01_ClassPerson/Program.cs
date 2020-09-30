using System;

namespace _01_ClassPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bonus
            var person1 = new Person();
            var person2 = new Person { Name = "Gosho", Age = 18 };
            var person3 = new Person { Name = "Stamat" };

            person1.Name = "Pesho";
            person1.Age = 20;

            person3.Age = 43;

            Console.WriteLine($"{nameof(person1)}: {person1.Name}, age: {person1.Age}");
            Console.WriteLine($"{nameof(person2)}: {person2.Name}, age: {person2.Age}");
            Console.WriteLine($"{nameof(person3)}: {person3.Name}, age: {person3.Age}");

            Console.ReadKey();
        }
    }
}
