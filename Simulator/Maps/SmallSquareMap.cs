namespace Simulator.Maps;

public class SmallSquareMap : SmallMap
{
    public readonly int Size;

    public SmallSquareMap(int sizeX, int sizeY) : base(sizeX, sizeY)
    {
       
    }
    

    public override Point Next(Point p, Direction d)
    {
        return d switch
        {
            Direction.Up => new Point(p.X, (p.Y + 1) % SizeY),
            Direction.Right => new Point((p.X + 1) % SizeX, p.Y),
            Direction.Down => new Point(p.X, (p.Y - 1 + SizeY) % Size),
            Direction.Left => new Point((p.X - 1 + SizeX) % Size, p.Y),
            _ => p
        };
    }

    public override Point NextDiagonal(Point p, Direction d)
    {
        return d switch
        {
            Direction.Up => new Point((p.X + 1) % Size, (p.Y + 1) % Size),           
            Direction.Right => new Point((p.X + 1) % Size, (p.Y - 1 + Size) % Size), 
            Direction.Down => new Point((p.X - 1 + Size) % Size, (p.Y - 1 + Size) % Size), 
            Direction.Left => new Point((p.X - 1 + Size) % Size, (p.Y + 1) % Size), 
            _ => p
        };
    }
}
