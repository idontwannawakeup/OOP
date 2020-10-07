using System;
using System.Collections.Generic;

namespace _07_FamilyTree
{
    class FamilyTree
    {
        private Member firstMember;
        private List<Member> parents;
        private List<Member> children;

        public bool IsInfoAboutFirstMember(string[] info)
        {
            return (firstMember.FirstName.Equals(info[0]) && firstMember.LastName.Equals(info[1])) ||
                    firstMember.Birthdate.Equals(info[2]);
        }

        public void UpdateInfoAboutFirstMember(string firstName, string lastName, string birthdate)
        {
            firstMember.FirstName = firstName;
            firstMember.LastName = lastName;
            firstMember.Birthdate = birthdate;
        }

        public void UpdateInfo(string[] info)
        {
            if (CheckInfo(info))
                AddInfoAboutParent(info);
            else
                UpdateInfoAboutMember(info[0], info[1], info[2]);
        }

        public void AddInfoAboutParent(string[] info)
        {
            if (info.Length == 5)
            {
                if (firstMember.FirstName.Equals(info[0]) &&
                    firstMember.LastName.Equals(info[1]))
                {
                    children.Add(new Member(info[3], info[4]));
                }
                else if (firstMember.FirstName.Equals(info[3]) &&
                         firstMember.LastName.Equals(info[4]))
                {
                    parents.Add(new Member(info[0], info[1]));
                }
            }
            else if (info.Length == 4 && info[2].Equals("-"))
            {
                if (firstMember.FirstName.Equals(info[0]) &&
                    firstMember.LastName.Equals(info[1]))
                {
                    children.Add(new Member(info[3]));
                }
                else if (firstMember.Birthdate.Equals(info[3]))
                {
                    parents.Add(new Member(info[0], info[1]));
                }
            }
            else if (info.Length == 4 && info[1].Equals("-"))
            {
                if (firstMember.Birthdate.Equals(info[0]))
                {
                    children.Add(new Member(info[2], info[3]));
                }
                else if (firstMember.FirstName.Equals(info[2]) &&
                         firstMember.LastName.Equals(info[3]))
                {
                    parents.Add(new Member(info[0]));
                }
            }
            else if (info.Length == 3)
            {
                if (firstMember.Birthdate.Equals(info[0]))
                {
                    children.Add(new Member(info[2]));
                }
                else if (firstMember.Birthdate.Equals(info[2]))
                {
                    parents.Add(new Member(info[0]));
                }
            }
        }

        public void UpdateInfoAboutMember(string firstName, string lastName, string birthdate)
        {
            Member memberToUpdate = GetMemberToUpdate(parents, firstName, lastName, birthdate);
            if (memberToUpdate == null)
                memberToUpdate = GetMemberToUpdate(children, firstName, lastName, birthdate);

            if (memberToUpdate != null)
            {
                memberToUpdate.FirstName = firstName;
                memberToUpdate.LastName = lastName;
                memberToUpdate.Birthdate = birthdate;
            }
        }

        private Member GetMemberToUpdate(List<Member> membersList, string firstName,
                                         string lastName, string birthdate)
        {
            Member result = null;
            foreach (var member in membersList)
                if ((member.FirstName.Equals(firstName) && member.LastName.Equals(lastName)) ||
                     member.Birthdate.Equals(birthdate))
                {
                    result = member;
                    break;
                }
            return result;
        }

        public void PrintTree()
        {
            Console.WriteLine(firstMember);
            Console.WriteLine("Parents:");
            foreach (var parent in parents)
                Console.WriteLine(parent);

            Console.WriteLine("Children:");
            foreach (var child in children)
                Console.WriteLine(child);
        }

        public static bool CheckInfo(string[] info)
        {
            foreach (var word in info)
                if (word.Equals("-"))
                    return true;

            return false;
        }

        public FamilyTree(string[] info)
        {
            firstMember = info.Length == 2 ? new Member(info[0], info[1]) : new Member(info[0]);
            parents = new List<Member>();
            children = new List<Member>();
        }
    }
}
