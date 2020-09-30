using System;

namespace _12_Google
{
    class FamilyMember
    {
        public string Name { get; }
        public DateTime BirthDay { get; }

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
}
