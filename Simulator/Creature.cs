﻿namespace Simulator;

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

    public string Go(Direction direction) => $"{direction.ToString().ToLower()}";

    public string[] Go(Direction[] directions)
    {
        return directions.Select(Go).ToArray();
    }

    public string[] Go(string input)
    {
        return Go(DirectionParser.Parse(input));
    }
}
    

