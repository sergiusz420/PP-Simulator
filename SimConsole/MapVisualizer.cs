using Simulator;
using Simulator.Maps;
namespace SimConsole
{
    public class MapVisualizer
    {
        private readonly Map _map;
        public MapVisualizer(Map map)
        {
            _map = map;
        }
        public void Draw()
        {
            int maxX = 0, maxY = 0;
            if (_map is SmallMap smallMap)
            {
                maxX = smallMap.Point.X;
                maxY = smallMap.Point.Y;
            }
            Console.Write(Box.TopLeft);
            for (int x = 0; x < maxX - 1; x++)
            {
                Console.Write($"{Box.Horizontal}{Box.Horizontal}{Box.Horizontal}{Box.TopMid}");
            }
            Console.WriteLine($"{Box.Horizontal}{Box.Horizontal}{Box.Horizontal}{Box.TopRight}");
            for (int y = 0; y < maxY; y++)
            {
                Console.Write(Box.Vertical);
                for (int x = 0; x < maxX; x++)
                {
                    var creatures = _map.At(new Point(x, y));
                    char symbol = creatures.Count() switch
                    {
                        0 => ' ',
                        1 => creatures.First() is Orc ? 'O' : 'E',
                        _ => 'X'
                    };
                    Console.Write($" {symbol} {Box.Vertical}");
                }
                Console.WriteLine();
                if (y < maxY - 1)
                {
                    Console.Write(Box.MidLeft);
                    for (int x = 0; x < maxX - 1; x++)
                    {
                        Console.Write($"{Box.Horizontal}{Box.Horizontal}{Box.Horizontal}{Box.Cross}");
                    }
                    Console.WriteLine($"{Box.Horizontal}{Box.Horizontal}{Box.Horizontal}{Box.MidRight}");
                }
            }
            Console.Write(Box.BottomLeft);
            for (int x = 0; x < maxX - 1; x++)
            {
                Console.Write($"{Box.Horizontal}{Box.Horizontal}{Box.Horizontal}{Box.BottomMid}");
            }
            Console.WriteLine($"{Box.Horizontal}{Box.Horizontal}{Box.Horizontal}{Box.BottomRight}");
        }
    }
}