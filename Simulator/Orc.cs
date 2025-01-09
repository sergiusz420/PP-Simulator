namespace Simulator;

public class Orc : Creature
{
    private int rage;
    private int huntCounter;

    public int Rage
    {
        get => rage;
        set => rage = Math.Clamp(value, 0, 10);
    }

    public Orc(string name, int level = 1, int agility = 0) : base(name, level)
    {
        Rage = agility;
    }

    public Orc() { }

    public override void SayHi()
    {
        Console.WriteLine($"Hi, I'm {Name}, my level is {Level}, my rage is {Rage}.");
    }

    public override int Power => (7 * Level) + (3 * Rage);

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
