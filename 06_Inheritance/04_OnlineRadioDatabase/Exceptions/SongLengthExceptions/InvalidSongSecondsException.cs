namespace _04_OnlineRadioDatabase.Exceptions.SongLengthExceptions
{
    class InvalidSongSecondsException : InvalidSongLengthException
    {
        public InvalidSongSecondsException()
            : base("Song seconds should be between 0 and 59.")
        { }
    }
}
