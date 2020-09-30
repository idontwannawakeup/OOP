namespace _12_Google
{
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
}
