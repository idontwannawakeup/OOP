using System.Collections.Generic;

namespace _03_OldestFamilyMember
{
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
}
