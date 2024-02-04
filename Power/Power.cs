namespace Power;

public static class Math
{
    public static double Power(double a, double b)
    {
        double accumulator = a;

        for (int i = 1; i < b; i++) accumulator *= a;

        return accumulator;
    }
}