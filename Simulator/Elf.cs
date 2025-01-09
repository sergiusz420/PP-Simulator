using System.ComponentModel.DataAnnotations;

namespace Simulator;

public class Elf : Creature
{
    private int agility;
    private int singCounter;

    public int Agility
    {
        get => agility;
        private set => agility = Math.Clamp(value, 0, 10);
    }

    public Elf(string name, int level = 1, int agility = 0) : base(name, level)
    {
        Agility = agility;
    }

    public Elf() { }

    public override void SayHi()
    {
        Console.WriteLine($"Hi, I'm {Name}, my level is {Level}, my agility is {Agility}.");
    }

    public override int Power => (8 * Level) + (2 * Agility);

    public void Sing()
    {
        singCounter++;
        if (singCounter % 3 == 0)
        {
            Agility += 1;
            if (Agility == 0)
            {
                Agility = 10;
            }
        }
      }
} 
