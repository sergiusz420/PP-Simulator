using Simulator;
namespace TestSimulator;

public class RectangleTests
{
    [Fact]
    public void TestRectangleCreation_ShouldBeCreated()
    {
        var rect = new Rectangle(4, 4, 6, 6);
        Assert.Equal(4, rect.X1);
        Assert.Equal(4, rect.Y1);
        Assert.Equal(6, rect.X2);
        Assert.Equal(6, rect.Y2);
    }

    [Fact]
    public void TestRectangleInvalidPoints_ShouldThrowException()
    {
        Assert.Throws<ArgumentException>(() => new Rectangle(3, 4, 3, 2));
    }

    [Fact]
    public void TestContains_PointsInRectangle_ShouldReturnTrue()
    {
        var rect = new Rectangle(2, 2, 7, 7);
        var point = new Point(4, 4);
        Assert.True(rect.Contains(point));
    }

    [Fact]
    public void TestContains_PointsOutsideRectangle_ShouldReturnFalse()
    {
        var rect = new Rectangle(2, 2, 7, 7);
        var point = new Point(10, 10);
        Assert.False(rect.Contains(point));
    }

    [Fact]
    public void TestToString_ShouldBeValidOutput()
    {
        int x1 = 1;
        int y1 = 6;
        int x2 = 4;
        int y2 = 7;
        var rectangle = new Rectangle(x1, y1, x2, y2);
        Assert.Equal("(1, 6):(4, 7)", rectangle.ToString());
    }
}
