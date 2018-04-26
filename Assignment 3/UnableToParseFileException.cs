using System;

namespace Assignment_3
{
    public class UnableToParseFileException : Exception
    {
        public UnableToParseFileException(string message) : base(message) { }
    }
}
