namespace Simulator;

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

    public abstract void SayHi();

    public abstract int Power {  get; }
    

    public string Info => $"{Name}, [{Level}]";

    public void Upgrade()
    {
        if (Level < 10)
        {
            _level++;
        }
    }

    public void Go(Direction direction) => Console.WriteLine($"{Name} goes {direction.ToString().ToLower()}.");

    public void Go(Direction[] directions)
    {
        foreach (var direction in directions)
        {
            Go(direction);
        }
    }

    public void Go(string input)
    {
        Go(DirectionParser.Parse(input));
    }
}
    

