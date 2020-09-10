using System;
using System.Collections.Generic;

namespace _03_OldestFamilyMember
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

        class Family
        {
            private List<Person> familyMembers;

            public Family()
            {
                familyMembers = new List<Person>();
            }

            public void AddMember(Person member)
            {
                familyMembers.Add(member);
            }

            public Person GetOldestMember()
            {
                int maxAge = familyMembers[0].Age;
                Person oldestMember = familyMembers[0];
                foreach (var member in familyMembers)
                {
                    if (member.Age > maxAge)
                    {
                        maxAge = member.Age;
                        oldestMember = member;
                    }
                }
                return oldestMember;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family goodFamily = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                goodFamily.AddMember(new Person(input[0], int.Parse(input[1])));
            }
            Person oldestMember = goodFamily.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");

            Console.ReadKey();
        }
    }
}
