using Simulator;
namespace TestSimulator;

public class ValidatorTests
{
    [Theory]
    [InlineData(3, 2, 5, 3)]
    [InlineData(1, 3, 7, 3)]
    [InlineData(9, 5, 8, 8)]
    public void TestLimiter_ShouldSetProperValue(int level, int min, int max, int expected)
    {
        Assert.Equal(expected, Validator.Limiter(level, min, max));
    }
}
