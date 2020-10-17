using System;

namespace _04_OnlineRadioDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var radio = new Radio();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(';');

                try
                {
                    radio.AddSong(new Song(info[0], info[1], info[2]));
                    Console.WriteLine("Song added.");
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }

            Console.WriteLine($"Songs added: {radio.Count}");
            Console.WriteLine($"Playlist length: {radio.TotalLength}");

            Console.ReadKey();
        }
    }
}
