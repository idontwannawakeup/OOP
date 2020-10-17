using _04_OnlineRadioDatabase.Exceptions.SongLengthExceptions;
using System;

namespace _04_OnlineRadioDatabase
{
    class SongDuration
    {
        private int minutes;
        private int seconds;

        public int Minutes
        {
            get => minutes;
            set
            {
                if (value < 0 || value > 14)
                    throw new InvalidSongMinutesException();

                minutes = value;
            }
        }

        public int Seconds
        {
            get => seconds;
            set
            {
                if (value < 0 || value > 59)
                    throw new InvalidSongSecondsException();

                seconds = value;
            }
        }

        public TimeSpan ToTimeSpan() => TimeSpan.Parse($"00:{Minutes}:{Seconds}");

        public static SongDuration Parse(string input)
        {
            string[] info = input.Split(':');

            if (info.Length != 2)
                throw new InvalidSongLengthException();

            return new SongDuration(int.Parse(info[0]), int.Parse(info[1]));
        }

        public SongDuration()
            : this(0, 0)
        { }

        public SongDuration(int minutes, int seconds)
        {
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
