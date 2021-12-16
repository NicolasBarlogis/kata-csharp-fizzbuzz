using FizzBuzzKata;
using Xunit;

namespace FizzBuzzKataTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Should_ShowCorrectValue_When_NoRule()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal("1",fizzBuzz.AnswerFor(1));
            Assert.Equal("2",fizzBuzz.AnswerFor(2));
            Assert.Equal("7",fizzBuzz.AnswerFor(7));
            Assert.Equal("11",fizzBuzz.AnswerFor(11));
        }
    }
}