namespace Simulator;

public static class Validator
{
    public static int Limiter(int value, int min, int max)
    {
        return Math.Clamp(value, min, max);
    }
}