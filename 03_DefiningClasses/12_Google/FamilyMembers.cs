using System.Collections.Generic;

namespace _12_Google
{
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
}
