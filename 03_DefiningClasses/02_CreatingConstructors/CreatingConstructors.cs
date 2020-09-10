using System;

namespace _02_CreatingConstructors
{
    class Program
    {
        class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get => name;
                set => name = value;
            }

            public int Age
            {
                get => age;
                set => age = value;
            }

            public Person()
            {
                name = "No name";
                age = 1;
            }

            public Person(int age)
            {
                name = "No name";
                this.age = age;
            }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        static void Main(string[] args)
        {
            var person = new Person(20);
            Console.WriteLine($"{nameof(person)}: {person.Name}, age: {person.Age}");

            Console.ReadKey();
        }
    }
}
