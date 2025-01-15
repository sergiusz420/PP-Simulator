using System.Text;
using Simulator;
using Simulator.Maps;
using SimConsole;
namespace Runner;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting Simulator!");
        Console.OutputEncoding = Encoding.UTF8;
        SmallSquareMap map = new SmallSquareMap(new Point(5, 5));
        List<Creature> creatures = [new Orc("Gorbag"), new Elf("Elandor")];
        List<Point> points = [new(2, 2), new(3, 1)];
        string moves = "dlrludl";

        Simulation simulation = new(map, creatures, points, moves);
        MapVisualizer mapVisualizer = new(simulation.Map);

    }

}   

   



