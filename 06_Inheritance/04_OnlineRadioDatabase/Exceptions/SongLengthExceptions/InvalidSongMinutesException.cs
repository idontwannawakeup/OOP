namespace _04_OnlineRadioDatabase.Exceptions.SongLengthExceptions
{
    class InvalidSongMinutesException : InvalidSongLengthException
    {
        public InvalidSongMinutesException()
            : base("Song minutes should be between 0 and 14.")
        { }
    }
}
