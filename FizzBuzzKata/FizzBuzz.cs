namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string AnswerFor(int number)
        {
            return number % 3 == 0 ? "fizz" : number.ToString();
        }
    }
}