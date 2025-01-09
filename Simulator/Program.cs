namespace Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Simulator!");
            Lab5a();
        }

        private static void Lab5a()
        {
            var rect1 = new Rectangle(3, 5, 5, 3);
            var rect2 = new Rectangle(new Point(5, 14), new Point(4, 12));

            Console.WriteLine(rect1);
            Console.WriteLine(rect2);

            try
            {
                var rect3 = new Rectangle(3, 3, 3, 5);
                var rect4 = new Rectangle(new Point(5, 16), new Point(8, 18));

                Console.WriteLine(rect3);
                Console.WriteLine(rect4);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }

            var rectpoint = new Rectangle(1, 5, 5, 1);
            var insidePoint = new Point(2, 2);
            var outsidePoint = new Point(10, 1);

            Console.WriteLine($"Rectangle: {rectpoint}");
            Console.WriteLine($"Contains {insidePoint}: {rectpoint.Contains(insidePoint)}");
            Console.WriteLine($"Contains {outsidePoint}: {rectpoint.Contains(outsidePoint)}");
        }
    }
}

