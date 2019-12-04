namespace FizzBuzz
{
    public class FizzBuzzService
    {
        public string GetText(int number)
        {
            if (Divisible(number, 3) && Divisible(number, 5))
                return "FizzBuzz";

            if (Divisible(number, 3))
                return "Fizz";

            if (Divisible(number, 5))
                return "Buzz";

            return number.ToString();
        }

        private bool Divisible(int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}
