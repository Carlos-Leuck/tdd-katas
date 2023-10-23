namespace FizzBuzz;

public static class FizzBuzz
{
    public static string Convert(int number)
    {
        if (number == 3)
            return "Fizz";
        return number.ToString();
    }
}
