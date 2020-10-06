using System;
using System.Collections.Generic;

namespace _13_FamilyTree
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPersonInfo = Console.ReadLine();
            Family family = new Family(firstPersonInfo.Split(' '));
            List<string[]> inputLines = new List<string[]>();

            string input = Console.ReadLine();
            while (!input.Equals("End"))
            {
                string[] info = input.Split(' ');
                bool check = Family.CheckInfo(info);

                if (!check && family.IsInfoAboutFirstMember(info))
                    family.UpdateInfoAboutFirstMember(info[0], info[1], info[2]);
                else
                    inputLines.Add(info);

                input = Console.ReadLine();
            }

            foreach (var line in inputLines)
                family.UpdateInfo(line);

            family.PrintTree();

            Console.ReadKey();
        }
    }
}
