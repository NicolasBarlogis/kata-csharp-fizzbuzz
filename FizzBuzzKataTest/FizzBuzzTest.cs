using System;
using FizzBuzzKata;
using Xunit;

namespace FizzBuzzKataTest
{
    public class FizzBuzzTest
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string FizzBuzz = "FizzBuzz";
        
        [Fact]
        public void Should_ShowNumber_When_NoRule()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal("1",fizzBuzz.AnswerFor(1));
            Assert.Equal("2",fizzBuzz.AnswerFor(2));
            Assert.Equal("7",fizzBuzz.AnswerFor(7));
            Assert.Equal("11",fizzBuzz.AnswerFor(11));
        }
        
        [Fact]
        public void Should_ShowFizz_When_MultipleOfThree()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal(Fizz,fizzBuzz.AnswerFor(3));
            Assert.Equal(Fizz,fizzBuzz.AnswerFor(6));
            Assert.Equal(Fizz,fizzBuzz.AnswerFor(12));
            Assert.Equal(Fizz,fizzBuzz.AnswerFor(18));
        }
        
        [Fact]
        public void Should_ShowFizz_When_ContainsThree()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal(Fizz,fizzBuzz.AnswerFor(13));
            Assert.Equal(Fizz,fizzBuzz.AnswerFor(31));
            Assert.Equal(Fizz,fizzBuzz.AnswerFor(43));
        }
        
        [Fact]
        public void Should_ShowBuzz_When_MultipleOfFive()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal(Buzz,fizzBuzz.AnswerFor(5));
            Assert.Equal(Buzz,fizzBuzz.AnswerFor(10));
            Assert.Equal(Buzz,fizzBuzz.AnswerFor(50));
            Assert.Equal(Buzz,fizzBuzz.AnswerFor(65));
        }
        
        [Fact]
        public void Should_ShowBuzz_When_ContainsFive()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal(Buzz,fizzBuzz.AnswerFor(52));
            Assert.Equal(Buzz,fizzBuzz.AnswerFor(56));
            Assert.Equal(Buzz,fizzBuzz.AnswerFor(59));
        }
        
        [Fact]
        public void Should_ShowBuzz_When_MultipleThreeOrContainsThreeANDMultipleFiveOrContainsFive()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal(FizzBuzz,fizzBuzz.AnswerFor(35));
            Assert.Equal(FizzBuzz,fizzBuzz.AnswerFor(53));
            Assert.Equal(FizzBuzz,fizzBuzz.AnswerFor(54));
            Assert.Equal(FizzBuzz,fizzBuzz.AnswerFor(90));
        }
        
        [Fact]
        public void Should_ShowFizzBuzz_When_MultipleOfThreeAndFive()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal(FizzBuzz,fizzBuzz.AnswerFor(15));
            Assert.Equal(FizzBuzz,fizzBuzz.AnswerFor(30));
            Assert.Equal(FizzBuzz,fizzBuzz.AnswerFor(60));
            Assert.Equal(FizzBuzz,fizzBuzz.AnswerFor(90));
        }
        
        [Fact]
        public void Should_NotWork_When_NumberIsOutOfRange()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Throws<ArgumentOutOfRangeException>(() => fizzBuzz.AnswerFor(0));
            Assert.Throws<ArgumentOutOfRangeException>(() => fizzBuzz.AnswerFor(101));
            Assert.Throws<ArgumentOutOfRangeException>(() => fizzBuzz.AnswerFor(500));
        }
        
        
    }
}