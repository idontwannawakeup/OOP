using System;
using System.Collections.Generic;

namespace _04_OnlineRadioDatabase
{
    class Radio
    {
        private List<Song> songs = new List<Song>();

        public int Count { get => songs.Count; }

        public string TotalLength { get => TotalLengthToString(); }

        private string TotalLengthToString()
        {
            var length = CalculateTotalLength();
            return $"{length.Hours}h {length.Minutes}m {length.Seconds}s";
        }

        private TimeSpan CalculateTotalLength()
        {
            var result = new TimeSpan();

            foreach (var item in songs)
                result = result.Add(item.Length.ToTimeSpan());

            return result;
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }
    }
}
