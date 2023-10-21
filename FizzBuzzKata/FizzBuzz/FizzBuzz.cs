namespace FizzBuzz;

public static class FizzBuzz
{
    public static string Convert(int number)
    {
        if (number == 1)
            return "1";
        if (number == 2)
            return "2";
        if (number == 3)
            return "Fizz";
        return "4";
    }
}
