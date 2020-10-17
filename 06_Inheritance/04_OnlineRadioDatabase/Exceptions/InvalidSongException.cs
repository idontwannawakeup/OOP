using System;

namespace _04_OnlineRadioDatabase.Exceptions
{
    class InvalidSongException : Exception
    {
        public InvalidSongException()
            : base("Invalid song.")
        { }

        public InvalidSongException(string message)
            : base(message)
        { }
    }
}
