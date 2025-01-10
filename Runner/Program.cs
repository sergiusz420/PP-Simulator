using Simulator;
namespace Runner;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting Simulator!");
        //Lab5a();
        //Lab5b();
    }

    //private static void Lab5a()
    //{
    //    var rect1 = new Rectangle(3, 5, 5, 3);
    //    var rect2 = new Rectangle(new Point(5, 14), new Point(4, 12));

    //    Console.WriteLine(rect1);
    //    Console.WriteLine(rect2);

    //    try
    //    {
    //        var rect3 = new Rectangle(3, 3, 3, 5);
    //        var rect4 = new Rectangle(new Point(5, 16), new Point(8, 18));

    //        Console.WriteLine(rect3);
    //        Console.WriteLine(rect4);
    //    }
    //    catch (ArgumentException ex)
    //    {
    //        Console.WriteLine($"Exception caught: {ex.Message}");
    //    }

    //    var rectpoint = new Rectangle(1, 5, 5, 1);
    //    var insidePoint = new Point(2, 2);
    //    var outsidePoint = new Point(10, 1);

    //    Console.WriteLine($"Rectangle: {rectpoint}");
    //    Console.WriteLine($"Contains {insidePoint}: {rectpoint.Contains(insidePoint)}");
    //    Console.WriteLine($"Contains {outsidePoint}: {rectpoint.Contains(outsidePoint)} \n\n\n");
    //}

    //public static void Lab5b()
    //{

    //    Console.WriteLine("Sprawdzenie czy mapa jest odpowiedniej wielkosci:");
    //    try
    //    {
    //        var map = new SmallSquareMap(4);
    //    }
    //    catch (ArgumentOutOfRangeException ex)
    //    {
    //        Console.WriteLine(ex.Message + "\n");
    //    }

    //    var Map = new SmallSquareMap(12);
    //    Console.WriteLine($"Map created with size: {Map.Size}");

    //    Console.WriteLine("\nMetoda Exist:");
    //    var pointInside = new Point(4, 3);
    //    bool isInside = Map.Exist(pointInside);
    //    Console.WriteLine($"Point {pointInside} inside map: {isInside}");

    //    var pointOutside = new Point(13, 15);
    //    bool isOutside = Map.Exist(pointOutside);
    //    Console.WriteLine($"Point {pointOutside} inside map: {isOutside}");

    //    Console.WriteLine("\nMetoda Next:");
    //    var startPoint = new Point(10, 3);
    //    var direction = Direction.Down;
    //    var nextPoint = Map.Next(startPoint, direction);
    //    Console.WriteLine($"Next point from {startPoint} towards {direction}: {nextPoint}");
    //    var Point1 = new Point(8, 4);
    //    var nextPoint1 = Map.Next(Point1, Direction.Up);
    //    Console.WriteLine($"Next point from {Point1} towards Up: {nextPoint1}");


    //    Console.WriteLine("\nMetoda NextDiagonal:");
    //    var diagonalNextPoint = Map.NextDiagonal(startPoint, Direction.Up);
    //    Console.WriteLine($"Next diagonal point from {startPoint} towards Up-Right: {diagonalNextPoint}");
    //    var startPoint1 = new Point(6, 1);
    //    var diagonaNextPoint1 = Map.NextDiagonal(startPoint1, Direction.Up);
    //    Console.WriteLine($"Next diagonal point from {startPoint1} towards Up-Right: {diagonaNextPoint1}");
    //}
}


