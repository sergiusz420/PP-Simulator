using Simulator;
namespace TestSimulator;

public class PointTests
{
    [Fact]
    public void TestConstructor_ShouldBeCreated()
    {
        int x = 4;
        int y = 9;
        var point = new Point(x, y);
        Assert.Equal(x, point.X);
        Assert.Equal(y, point.Y);
    }

    [Fact]
    public void TestToString_ShouldBeValidOutput()
    {
        var point = new Point(3, 4);
        Assert.Equal("(3, 4)", point.ToString());
    }

    [Theory]
    [InlineData(4, 8, Direction.Up, 4, 9)]
    [InlineData(4, 8, Direction.Right, 5, 8)]
    [InlineData(4, 8, Direction.Down, 4, 7)]
    [InlineData(4, 8, Direction.Left, 3, 8)]
    public void TestNext_ShouldReturnCorrectPoint(int x, int y, Direction d, int expectedX, int expectedY)
    {
        var point = new Point(x, y);
        Assert.Equal(new Point(expectedX, expectedY), point.Next(d));
    }

    [Theory]
    [InlineData(4, 8, Direction.Up, 5, 9)]
    [InlineData(4, 8, Direction.Right, 5, 7)]
    [InlineData(4, 8, Direction.Down, 3, 7)]
    [InlineData(4, 8, Direction.Left, 3, 9)]
    public void TestNextDiagonal_ShouldReturnCorrectPoint(int x, int y, Direction d, int expectedX, int expectedY)
    {
        var point = new Point(x, y);
        var nextPoint = point.NextDiagonal(d);
        Assert.Equal(expectedX, nextPoint.X);
        Assert.Equal(expectedY, nextPoint.Y);
    }
}

