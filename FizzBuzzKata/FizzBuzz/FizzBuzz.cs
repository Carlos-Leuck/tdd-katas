namespace FizzBuzz;

public static class FizzBuzz
{
    public static string Convert(int number)
    {
        if (IsMultipleOfThree(number) && IsMultipleOfFive(number))
            return "FizzBuzz";
        if (IsMultipleOfThree(number))
            return "Fizz";
        if (IsMultipleOfFive(number))
            return "Buzz";
        return number.ToString();

        static bool IsMultipleOfThree(int number)
        {
            return number % 3 == 0;
        }

        static bool IsMultipleOfFive(int number)
        {
            return number % 5 == 0;
        }
    }
}
