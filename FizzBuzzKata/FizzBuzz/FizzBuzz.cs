namespace FizzBuzz;

public static class FizzBuzz
{
    public static string Convert(int number)
    {
        if (number % 3 == 0)
            return "Fizz";
        if (number % 5 == 0)
            return "Buzz";
        return number.ToString();
    }
}
