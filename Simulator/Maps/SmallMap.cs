
namespace Simulator.Maps
{
    public  class SmallMap : Map
    {
        public Point Point { get; }
        protected SmallMap(Point point)
        {
            if (point.X > 20 || point.Y > 20)
            {
                throw new ArgumentOutOfRangeException("Maksymalna wielkość mapy to 20");
            }
            Point = new Point(point.X, point.Y);
        }

        private Dictionary<Point, List<Creature>> creatures = new Dictionary<Point, List<Creature>>();
     
        public override bool Exist(Point p)
        {
            return p.X >= 0 && p.X < Point.X && p.Y >= 0 && p.Y < Point.Y;
        }
        public override Point Next(Point p, Direction d)
        {
            throw new NotImplementedException();
        }

        public override Point NextDiagonal(Point p, Direction d)
        {
            throw new NotImplementedException();
        }

        public override void Add(Creature creature, Point point)
        {
            if (!creatures.ContainsKey(point))
            {
                creatures[point] = new List<Creature>();
            }
            creatures[point].Add(creature);
        }

        public override Point Move(Creature creature, Point startpos, Direction direction)
        {
            Point newPosition = Next(startpos, direction); 
            if (Exist(newPosition))
            {
                Remove(creature, startpos);
                Add(creature, newPosition);
                return newPosition;
            }
            return startpos; 
        }

        public override void Remove(Creature creature, Point point)
        {
            if (creatures.TryGetValue(point, out List<Creature> list))
            {
                list.Remove(creature);
                if (list.Count == 0)
                {
                    creatures.Remove(point);
                }
            }
        }

        public override IEnumerable<Creature> At(Point point)
        {
            return creatures.TryGetValue(point, out List<Creature> list) ? list : Enumerable.Empty<Creature>();
        }
    }
}
