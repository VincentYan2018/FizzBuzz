using System;

namespace FizzBuzz
{
    public class InvalidOperationException : Exception
    {
        public InvalidOperationException(string message) : base(message)
        {
        }
    }
}