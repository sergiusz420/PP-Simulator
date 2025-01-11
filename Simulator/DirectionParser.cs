namespace Simulator;

public static class DirectionParser
{
    public static List<Direction> Parse(string input)
    {
        var directions = new List<Direction>();

        foreach (char c in input.ToUpper())
        {
            if (c == 'U')
            {
                directions.Add(Direction.Up);
            }
            else if (c == 'R')
            {
                directions.Add(Direction.Right);
            }
            else if (c == 'D')
            {
                directions.Add(Direction.Down);
            }
            else if (c == 'L')
            {
                directions.Add(Direction.Left);
            }
        }
        return directions;
    }
}