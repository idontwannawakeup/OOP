using System;

namespace _05_CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Replace(" ", "").ToCharArray();
            char[] arr2 = Console.ReadLine().Replace(" ", "").ToCharArray();

            char[] shorterArr = arr1.Length <= arr2.Length ? arr1 : arr2;
            char[] longestArr = arr1.Length > arr2.Length ? arr1 : arr2;

            bool areLettersEqual = true;
            for (int i = 0; i < shorterArr.Length; i++)
            {
                if (shorterArr[i] < longestArr[i])
                {
                    Console.WriteLine(shorterArr);
                    Console.WriteLine(longestArr);
                    areLettersEqual = false;
                    break;
                }
                else if (longestArr[i] < shorterArr[i])
                {
                    Console.WriteLine(longestArr);
                    Console.WriteLine(shorterArr);
                    areLettersEqual = false;
                    break;
                }
            }

            if (areLettersEqual)
            {
                Console.WriteLine(shorterArr);
                Console.WriteLine(longestArr);
            }

            Console.ReadKey();
        }
    }
}
