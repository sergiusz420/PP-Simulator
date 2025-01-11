namespace Simulator;
using Simulator.Maps;
public abstract class Creature
{
    private string _name = "Unknown";
    private int _level = 1;
    

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

    public Creature() { }

    public abstract string Greeting();

    public abstract int Power {  get; }

    public abstract string Info { get; }

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

    public Map? Map {  get; set; }
    public Point Position { get; set; }
    public string Go(Direction direction)
    {
        if (Map == null)
        {
            return ("Brak przypisanej mapy");
        }
        var newPos = Position.Next(direction);
        if (Map.Exist(newPos))
        {
            Map.Move(this, Position, newPos);
            Position = newPos;  
        }
        return $"Poruszono {direction.ToString().ToLower()} do {newPos}.";
    }

    public void AssignMap(Map map, Point startPosition)
    {
        Map = map;
        Position = startPosition;
        map.Add(this, Position);
    }
}
    

