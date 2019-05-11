using System;

namespace FizzBuzz
{
    public class NoAvailableParkingSpaceException : Exception
    {
        public NoAvailableParkingSpaceException():base("There are no available parking space!")
        {
            
        }
    }
}