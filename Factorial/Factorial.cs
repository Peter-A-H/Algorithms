namespace Factorial;

public static class Math
{
    public static object Factorial(int n)
    {
        if (n < 0) return "Factorial does not exist for negative integers";
        else if (n == 0) return 1;
        else
        {
            int accumulator = 1;

            for (int i = 1; i < n + 1; i++) accumulator *= i;

            return accumulator;
        }
    }
}