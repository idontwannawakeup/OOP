namespace _07_FamilyTree
{
    class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get; set; }

        public override string ToString()
        {
            return new string($"{FirstName} {LastName} {Birthdate}");
        }

        public Member(string birthdate)
            : this("unknown", "unknown", birthdate) { }

        public Member(string firstName, string lastName)
            : this(firstName, lastName, "unknown") { }

        public Member(string firstName, string lastName, string birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
        }
    }
}
