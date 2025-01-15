namespace Simulator;
using Simulator.Maps;
public abstract class Creature
{
    private string _name = "Unknown";
    private int _level = 1;
    private Map? _map = null;


    public string Name
    {
        get => _name;
        init
        {
            _name = value;
            _name = _name.Trim();
            if (_name.Length > 25)
            {
                _name = _name.Substring(0, 25).TrimEnd();
            }
            if (_name.Length < 3)
            {
                _name = _name.PadRight(3, '#');
            }
          
            _name = char.ToUpper(_name[0]) + _name.Substring(1);
        }
    }

    public int Level
    {
        get => _level;
        set
        {
            _level = value;
            _level = _level < 1 ? 1 : _level;
            _level = _level > 10 ? 10 : _level;
        }
    }
   

    public Creature(string name, int level = 1)
    {
        Name = name;
        Level = level;
    }

    

    protected Creature() { }

    public abstract string Greeting();

    public abstract int Power {  get; }

    public abstract string Info { get; }



    protected Creature(string name, int level = 1, Point? position = null, Map? map = null)
    {
        Name = name;
        Level = level;
        Position = position ?? new Point(0, 0);
        Map = map;
    }

    public override string ToString()
    {
        return $"{GetType().Name.ToUpper()}: {Info}";
    }

    public void Upgrade()
    {
        if (Level < 10)
        {
            _level++;
        }
    }

    public Map? Map
    {
        get => _map;
        set
        {
            _map ??= value;
        }
    }
    public Point? Position { get; set; }
    public object CurrentPosition { get; set; }

    public Point Go(Direction direction)
    {
        if (Map == null || Position == null)
        {
            Console.WriteLine($"[ERROR] Creature {Name} has invalid Map or Position. Map: {Map}, Position: {Position}");
            throw new InvalidOperationException("Creature must be placed on a map with a valid position before moving.");
        }
       
        Point newPosition = Map.Move(this, Position.Value, direction);
        Position = newPosition;
        return newPosition;
    }   
}
    

