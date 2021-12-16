using FizzBuzzKata;
using Xunit;

namespace FizzBuzzKataTest
{
    public class FizzBuzzTest
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        
        [Fact]
        public void Should_ShowCorrectValue_When_NoRule()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal("1",fizzBuzz.AnswerFor(1));
            Assert.Equal("2",fizzBuzz.AnswerFor(2));
            Assert.Equal("7",fizzBuzz.AnswerFor(7));
            Assert.Equal("11",fizzBuzz.AnswerFor(11));
        }
        
        [Fact]
        public void Should_ShowCorrectValue_When_MultipleOfThree()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal(Fizz,fizzBuzz.AnswerFor(3));
            Assert.Equal(Fizz,fizzBuzz.AnswerFor(6));
            Assert.Equal(Fizz,fizzBuzz.AnswerFor(12));
            Assert.Equal(Fizz,fizzBuzz.AnswerFor(18));
        }
        
        [Fact]
        public void Should_ShowCorrectValue_When_MultipleOfFive()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal(Buzz,fizzBuzz.AnswerFor(5));
            Assert.Equal(Buzz,fizzBuzz.AnswerFor(10));
            Assert.Equal(Buzz,fizzBuzz.AnswerFor(50));
            Assert.Equal(Buzz,fizzBuzz.AnswerFor(65));
        }
    }
}