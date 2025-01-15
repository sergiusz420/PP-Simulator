
namespace Simulator.Maps;

/// <summary>
/// Map of points.
/// </summary>
public abstract class Map
{

    /// <summary>
    /// Check if given point belongs to the map.
    /// </summary>
    /// <param name="p">Point to check.</param>
    /// <returns></returns>
    public abstract bool Exist(Point p);

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
    public abstract Point Move(Creature creature, Point startpos, Direction direction);

    /// <summary>
    /// removes creature from the map
    /// </summary>
    /// <param name="c">Creature.</param>
    /// <param name="p">Point.</param>
    /// <returns></returns>
    public abstract void Remove(Creature creature, Point point);

    public abstract IEnumerable<Creature> At(Point point);

    
}
