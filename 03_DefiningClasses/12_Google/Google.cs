using System;
using System.Collections.Generic;

namespace _12_Google
{
    class Program
    {
        class Company
        {
            public string Name { get; }
            public string Department { get; }
            public double Salary { get; }

            public override string ToString()
            {
                return new string($"{Name} {Department} {string.Format("{0:0.00}", Salary)}\n");
            }

            public Company(string name, string department, double salary)
            {
                Name = name;
                Department = department;
                Salary = salary;
            }
        }

        class Pokemon
        {
            public string Name { get; }
            public string Type { get; }

            public override string ToString()
            {
                return new string($"{Name} {Type}\n");
            }

            public Pokemon(string name, string type)
            {
                Name = name;
                Type = type;
            }
        }

        class FamilyMember
        {
            public string Name { get; }
            public DateTime BirthDay{ get; }

            public override string ToString()
            {
                return new string($"{Name} {BirthDay}\n");
            }

            public FamilyMember(string name, string birthDay)
                : this(name, DateTime.Parse(birthDay)) { }

            public FamilyMember(string name, DateTime birthDay)
            {
                Name = name;
                BirthDay = birthDay;
            }
        }

        class Car
        {
            public string Model { get; }
            public int Speed { get; }

            public override string ToString()
            {
                return new string($"{Model} {Speed}\n");
            }

            public Car(string model, int speed)
            {
                Model = model;
                Speed = speed;
            }
        }

        class FamilyMembers
        {
            public List<FamilyMember> Data { get; }

            public void Add(FamilyMember newMember)
            {
                Data.Add(newMember);
            }

            public override string ToString()
            {
                string result = new string("");

                foreach (var item in Data)
                {
                    result += item.ToString();
                }    

                return result;
            }

            public FamilyMembers()
            {
                Data = new List<FamilyMember>();
            }
        }

        class Pokemons
        {
            public List<Pokemon> Data { get; }

            public void Add(Pokemon newPokemon)
            {
                Data.Add(newPokemon);
            }

            public override string ToString()
            {
                string result = new string("");

                foreach (var item in Data)
                {
                    result += item.ToString();
                }

                return result;
            }

            public Pokemons()
            {
                Data = new List<Pokemon>();
            }
        }

        class Person
        {
            public string Name { get; }
            public Company Company_ { get; private set; }
            public Car Car_ { get; private set; }
            public FamilyMembers Parents { get; }
            public FamilyMembers Children { get; }
            public Pokemons Pokemons_ { get; }

            public void UpdateInfo(string[] info)
            {
                string field = info[1];

                if (field.Equals("company"))
                {
                    Company_ = new Company(info[2], info[3], double.Parse(info[4].Replace('.', ',')));
                }
                else if (field.Equals("pokemon"))
                {
                    Pokemons_.Add(new Pokemon(info[2], info[3]));
                }
                else if (field.Equals("parents"))
                {
                    Parents.Add(new FamilyMember(info[2], info[3]));
                }
                else if (field.Equals("children"))
                {
                    Children.Add(new FamilyMember(info[2], info[3]));
                }
                else if (field.Equals("car"))
                {
                    Car_ = new Car(info[2], int.Parse(info[3]));
                }
            }

            public override string ToString()
            {
                return new string($"{Name}\n" +
                                  $"Company:\n{Company_}" +
                                  $"Car:\n{Car_}" +
                                  $"Pokemon:\n{Pokemons_}" +
                                  $"Parents:\n{Parents}" +
                                  $"Children:\n{Children}");
            }

            public Person(string name)
            {
                Name = name;
                Company_ = null;
                Car_ = null;
                Parents = new FamilyMembers();
                Children = new FamilyMembers();
                Pokemons_ = new Pokemons();
            }
        }

        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Person> persons = new List<Person>();
            while (!command.Equals("End"))
            {
                string[] info = command.Split(' ');
                string name = info[0];
                bool check = false;

                Person currentPerson = new Person(name);
                foreach (var person in persons)
                {
                    if (person.Name.Equals(name))
                    {
                        check = true;
                        currentPerson = person;
                        break;
                    }
                }

                if (!check)
                {
                    persons.Add(currentPerson);
                }
                currentPerson.UpdateInfo(info);

                command = Console.ReadLine();
            }

            string inputName = Console.ReadLine();
            foreach (var person in persons)
            {
                if (person.Name.Equals(inputName))
                {
                    Console.WriteLine(person);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
