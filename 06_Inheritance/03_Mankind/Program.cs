using System;

namespace _03_Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] studentInfo = Console.ReadLine().Split(' ');
                var student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);

                string[] workerInfo = Console.ReadLine().Split(' ');
                var worker = new Worker(workerInfo[0], workerInfo[1],
                                        double.Parse(workerInfo[2].Replace('.', ',')),
                                        int.Parse(workerInfo[3]));

                Console.WriteLine(student + Environment.NewLine);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            Console.ReadKey();
        }
    }
}
