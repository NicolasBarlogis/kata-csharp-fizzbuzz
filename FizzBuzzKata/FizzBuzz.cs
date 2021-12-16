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
            if (MatchRuleThree(number) && MatchRuleFive(number))
            {
                return "FizzBuzz";
            }
            if (MatchRuleThree(number))
            {
                return "Fizz";
            } 
            if (MatchRuleFive(number))
            {
                return "Buzz";
            }
            return number.ToString();
        }

        private bool MatchRule(int number, int reference)
        {
            return number % reference == 0 || number.ToString().Contains(reference.ToString());
        }

        private bool MatchRuleThree(int number)
        {
            return MatchRule(number, 3);
        }
        
        private bool MatchRuleFive(int number)
        {
            return MatchRule(number, 5);
        }
    }
}