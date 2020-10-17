using _04_OnlineRadioDatabase.Exceptions;

namespace _04_OnlineRadioDatabase
{
    class Song
    {
        private string name;
        private string artist;
        public SongDuration Length { get; set; }

        public string Name
        {
            get => name;
            private set
            {
                if (value.Length < 3 || value.Length > 30)
                    throw new InvalidSongNameException();

                name = value;
            }
        }

        public string Artist
        {
            get => artist;
            private set
            {
                if (value.Length < 3 || value.Length > 20)
                    throw new InvalidArtistNameException();

                artist = value;
            }
        }

        public Song(string artist, string name, string length)
            : this(artist, name, SongDuration.Parse(length))
        { }

        public Song(string artist, string name, SongDuration length)
        {
            Artist = artist;
            Name = name;
            Length = length;
        }
    }
}
