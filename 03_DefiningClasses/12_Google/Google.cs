using System;
using System.Collections.Generic;

namespace _12_Google
{
    class Program
    {
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
                    if (person.Name.Equals(name))
                    {
                        check = true;
                        currentPerson = person;
                        break;
                    }

                if (!check)
                    persons.Add(currentPerson);

                currentPerson.UpdateInfo(info);

                command = Console.ReadLine();
            }

            string inputName = Console.ReadLine();
            foreach (var person in persons)
                if (person.Name.Equals(inputName))
                {
                    Console.WriteLine(person);
                    break;
                }

            Console.ReadKey();
        }
    }
}
