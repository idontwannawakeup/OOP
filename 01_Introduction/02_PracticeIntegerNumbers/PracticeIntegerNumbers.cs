using System;

namespace _02_PracticeIntegerNumbers
{
    class PracticeIntegerNumbers
    {
        static void Main(string[] args)
        {
            sbyte sbNegNum = -100;
            byte bNum = 128;
            short sNegNum = -3540;
            ushort usNum = 64876;
            uint uNum = 2147483648;
            int negNum = -1141583228;
            long lNegNum = -1223372036854775808;

            Console.WriteLine(sbNegNum);
            Console.WriteLine(bNum);
            Console.WriteLine(sNegNum);
            Console.WriteLine(usNum);
            Console.WriteLine(uNum);
            Console.WriteLine(negNum);
            Console.WriteLine(lNegNum);

            Console.ReadKey();
        }
    }
}
