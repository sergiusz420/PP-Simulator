﻿namespace Simulator;

public class Orc : Creature
{
    private int rage;
    private int huntCounter;

    public int Rage
    {
        get => rage;
        set => rage = Validator.Limiter(value, 0, 10);
    }

    public Orc(string name, int level = 1, int rage = 0 ) : base(name, level)
    {
        Rage = rage;
    }

    

  

    public override string Greeting()
    {
        string introduce = $"Hi, I'm {Name}, my level is {Level}, my rage is {Rage}.";
        return introduce;
    }

    public override string Info => $"{Name} [{Level}][{Rage}]";

    public override int Power => (7 * Level) + (3 * Rage);

    public Point Point { get; }

    public void Hunt()
    {
        huntCounter++;
        if (huntCounter % 2 == 0) 
        {
            Rage++;
            if (Rage > 10) 
            {
                Rage = 10;
            }
        }
    }
}
