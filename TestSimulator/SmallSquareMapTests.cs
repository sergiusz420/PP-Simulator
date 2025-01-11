using Simulator;
using Simulator.Maps;
namespace TestSimulator;

public class SmallSquareMapTests
{
    [Fact]
    public void TestConstructor_ValidSize_ShouldSetSize()
    {
        int size = 10;
        var map = new SmallTorusMap(size);       
        Assert.Equal(size, map.Size);
    }

    [Theory]
    [InlineData(4)]
    [InlineData(21)]
    public void
      TestConstructor_InvalidSize_ShouldThrowArgumentOutOfRangeException
      (int size)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
             new SmallTorusMap(size));
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(6, 1, 5, false)]
    [InlineData(19, 19, 20, true)]
    [InlineData(20, 20, 20, false)]
    public void TestExist_ShouldReturnCorrectValue(int x, int y,
    int size, bool expected)
    {
        var map = new SmallTorusMap(size);
        var point = new Point(x, y);
        var result = map.Exist(point);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(5, 10, Direction.Up, 5, 11)]
    [InlineData(0, 0, Direction.Down, 0, 19)]
    [InlineData(0, 8, Direction.Left, 19, 8)]
    [InlineData(19, 10, Direction.Right, 0, 10)]
    public void TestNext_ShouldReturnCorrectNextPoint(int x, int y,
    Direction direction, int expectedX, int expectedY)
    {
        var map = new SmallTorusMap(20);
        var point = new Point(x, y);
        var nextPoint = map.Next(point, direction);
        Assert.Equal(new Point(expectedX, expectedY), nextPoint);
    }

    [Theory]
    [InlineData(5, 10, Direction.Up, 6, 11)]
    [InlineData(0, 0, Direction.Down, 19, 19)]
    [InlineData(0, 8, Direction.Left, 19, 9)]
    [InlineData(19, 10, Direction.Right, 0, 9)]

    public void TestNextDiagonal_ShouldReturnCorrectNextPoint(int x, int y,
    Direction direction, int expectedX, int expectedY)
    {
        var map = new SmallTorusMap(20);
        var point = new Point(x, y);
        var nextPoint = map.NextDiagonal(point, direction);
        Assert.Equal(new Point(expectedX, expectedY), nextPoint);
    }
}
