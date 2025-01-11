namespace Simulator.Maps;

/// <summary>
/// Map of points.
/// </summary>
public abstract class Map
{
    public int SizeX { get; }
    public int SizeY { get; }

    public Map(int sizeX, int sizeY) 
    {
        if (sizeX < 5 || sizeY < 5) throw new ArgumentOutOfRangeException("Minimalna wielkosc mapy to 5");
        SizeX = sizeX;
        SizeY = sizeY;
    }

    /// <summary>
    /// Check if give point belongs to the map.
    /// </summary>
    /// <param name="p">Point to check.</param>
    /// <returns></returns>
    public virtual bool Exist(Point p)
    {
        var mapBounds = new Rectangle(0, 0, SizeX - 1, SizeY - 1);
        if (mapBounds.Contains(p))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Next position to the point in a given direction.
    /// </summary>
    /// <param name="p">Starting point.</param>
    /// <param name="d">Direction.</param>
    /// <returns>Next point.</returns>
    public abstract Point Next(Point p, Direction d);

    /// <summary>
    /// Next diagonal position to the point in a given direction 
    /// rotated 45 degrees clockwise.
    /// </summary>
    /// <param name="p">Starting point.</param>
    /// <param name="d">Direction.</param>
    /// <returns>Next point.</returns>
    public abstract Point NextDiagonal(Point p, Direction d);

    /// <summary>
    /// Adds creature to the map 
    /// </summary>
    /// <param name="c">Creature.</param>
    /// <param name="p">Point.</param>
    /// <returns></returns>
    public abstract void Add(Creature creature, Point point);
    /// <summary>
    /// Moves creature on the map
    /// </summary>
    /// <param name="c">Creature.</param>
    /// <param name="p">Point.</param>
    /// <param name="d">Direction.</param>
    /// <returns>Next point.</returns>
    public abstract void Move(Creature creature, Point oldpos, Point newpos);
    /// <summary>
    /// removes creature from the map
    /// </summary>
    /// <param name="c">Creature.</param>
    /// <param name="p">Point.</param>
    /// <returns></returns>
    public abstract void Remove(Creature creature, Point point);

    public abstract List<Creature> At(Point point);
}
