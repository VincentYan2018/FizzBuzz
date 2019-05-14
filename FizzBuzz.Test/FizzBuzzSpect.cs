using Xunit;

namespace FizzBuzz.Test
{
    public class FizzBuzzSpect
    {
        [Fact]
        public void should_return_invalid_num_when_the_number_is_out_range_from_1_to_100()
        {
            var fizzBuzz = new FizzBuzz();
            const string numStr1 = "0";
            var result1 = fizzBuzz.generatePrintValue(numStr1);
            Assert.Equal("The number is invalid. Please input number from 1 to 100.", result1);
            
            const string numStr2 = "101";
            var result2 = fizzBuzz.generatePrintValue(numStr2);
            Assert.Equal("The number is invalid. Please input number from 1 to 100.", result2);
        }
        [Fact]
        public void should_return_invalid_num_when_the_number_is_not_an_integer()
        {
            var fizzBuzz = new FizzBuzz();
            const string numStr1 = "0.1";
            var result1 = fizzBuzz.generatePrintValue(numStr1);
            Assert.Equal("The number is invalid. Please input an integer from 1 to 100.", result1);
            
            const string numStr2 = "abc";
            var result2 = fizzBuzz.generatePrintValue(numStr2);
            Assert.Equal("The number is invalid. Please input an integer from 1 to 100.", result2);
        }

        [Fact]
        public void should_return_the_number_when_the_number_is_neither_multiples_of_three_or_five()
        {
            var fizzBuzz = new FizzBuzz();
            const string numStr1 = "1";
            var result1 = fizzBuzz.generatePrintValue(numStr1);
            Assert.Equal("1", result1);

            const string numStr2 = "3";
            var result2 = fizzBuzz.generatePrintValue(numStr2);
            Assert.NotEqual("3", result2);

            const string numStr3 = "5";
            var result3 = fizzBuzz.generatePrintValue(numStr3);
            Assert.NotEqual("5", result3);
        }
        [Fact]
        public void should_return_Fizz_when_the_number_is_multiples_of_three()
        {
            var fizzBuzz = new FizzBuzz();
            const string numStr1 = "3";
            var result1 = fizzBuzz.generatePrintValue(numStr1);
            Assert.Equal("Fizz", result1);
        }
        
        [Fact]
        public void should_return_Buzz_when_the_number_is_multiples_of_five()
        {
            var fizzBuzz = new FizzBuzz();
            const string numStr1 = "5";
            var result1 = fizzBuzz.generatePrintValue(numStr1);
            Assert.Equal("Buzz", result1);
        }
        
        [Fact]
        public void should_return_Buzz_when_the_number_is_multiples_of_three_and_five()
        {
            var fizzBuzz = new FizzBuzz();
            const string numStr1 = "15";
            var result1 = fizzBuzz.generatePrintValue(numStr1);
            Assert.Equal("FizzBuzz", result1);
        }
    }
}