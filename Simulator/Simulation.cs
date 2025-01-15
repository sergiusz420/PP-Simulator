using Simulator.Maps;
using Simulator;

public class Simulation
{
    
    /// <summary>
    /// Simulation's map.
    /// </summary>
    public Map Map { get; }
    /// <summary>
    /// Creatures moving on the map.
    /// </summary>
    public List<Creature> Creatures { get; }
    /// <summary>
    /// Starting positions of creatures.
    /// </summary>
    public List<Point> Positions { get; }
    /// <summary>
    /// Cyclic list of creatures moves. 
    /// Bad moves are ignored - use DirectionParser.
    /// First move is for first creature, second for second and so on.
    /// When all creatures make moves, 
    /// next move is again for first creature and so on.
    /// </summary>
    public string Moves { get; }
    /// <summary>
    /// Has all moves been done?
    /// </summary>
    public bool Finished { get; private set; } = false;
    /// <summary>
    /// Creature which will be moving current turn.
    /// </summary>
    public Creature CurrentCreature => Creatures[_currentTurn % Creatures.Count];
    /// <summary>
    /// Lowercase name of direction which will be used in current turn.
    /// </summary>
    public string CurrentMoveName => _parsedMoves[_currentTurn % _parsedMoves.Count].ToString().ToLower();

    private readonly List<Direction> _parsedMoves;
    private int _currentTurn = 0;
  
    public Simulation(Map map, List<Creature> creatures, List<Point> positions, string moves)
    {
        if (creatures == null || creatures.Count == 0)
            throw new ArgumentException("Lista nie może byc pusta.");
        if (creatures.Count != positions.Count)
            throw new ArgumentException("Musi byc tyle potworow co pól.");
        Map = map;
        Creatures = creatures;
        Positions = positions;
        Moves = moves;
        _parsedMoves = DirectionParser.Parse(moves);
        for (int i = 0; i < creatures.Count; i++)
        {
            creatures[i].Position = positions[i];
            map.Add(creatures[i], positions[i]);
        }
    }
    /// <summary>
    /// Makes one move of current creature in current direction.
    /// Throw error if simulation is finished.
    /// </summary>
    public void Turn()
    {
        if (Finished)
            throw new InvalidOperationException("Symulacja jest już zakończona.");

        var currentMove = _parsedMoves[_currentTurn % _parsedMoves.Count];
        var currentCreature = CurrentCreature;
        Point newPosition = currentCreature.Go(currentMove);
        Console.WriteLine($"New position: {newPosition}");
        _currentTurn++;

        if (_currentTurn >= _parsedMoves.Count * Creatures.Count)
        {
            Finished = true;
        }
    }
}