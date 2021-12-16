using System;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string AnswerFor(int number)
        {
            if (number is < 1 or > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
            if ((number % 3 == 0 || number.ToString().Contains(3.ToString())) && 
                (number % 5 == 0 || number.ToString().Contains(5.ToString())))
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0 || number.ToString().Contains(3.ToString()))
            {
                return "Fizz";
            } 
            if (number % 5 == 0 || number.ToString().Contains(5.ToString()))
            {
                return "Buzz";
            }
            return number.ToString();
        }
    }
}