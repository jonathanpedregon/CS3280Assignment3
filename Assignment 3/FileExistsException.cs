using System;

namespace Assignment_3
{
    public class FileExistsException : Exception
    {
        public FileExistsException(string message) : base(message) { }
    }
}
