using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string generatePrintValue(string numStr)
        {
            int num;
            try
            {
                num = int.Parse(numStr);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return "The number is invalid. Please input an integer from 1 to 100.";
            }

            if (num < 1 || num > 100)
            {
                return "The number is invalid. Please input number from 1 to 100.";
            }

            if (num % 15 == 0)
            {
                return "FizzBuzz";
            }

            if (num % 5 == 0)
            {
                return "Buzz";
            }

            return num % 3 == 0 ? "Fizz" : num.ToString();
        }
    }
}