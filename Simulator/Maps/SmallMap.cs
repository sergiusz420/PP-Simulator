namespace Simulator.Maps
{
    public  class SmallMap : Map
    {
        protected SmallMap(int sizeX, int sizeY) : base(sizeX, sizeY)
        {
            if (sizeX > 20 || sizeY > 20)
            {
                throw new ArgumentOutOfRangeException("Maksymalna wielkość mapy to 20");
            }
        }

        private Dictionary<Point, List<Creature>> creatures = new Dictionary<Point, List<Creature>>();
        public int SizeX { get; }
        public int SizeY { get; }
        public override bool Exist(Point p)
        {
            return p.X >= 0 && p.X < SizeX && p.Y >= 0 && p.Y < SizeY;
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

        public override void Move(Creature creature, Point startpos, Point newpos)
        {
            Remove(creature, startpos);
            Add(creature, newpos);
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

        public override List<Creature> At(Point position)
        {
            return creatures.ContainsKey(position) ? creatures[position] : new List<Creature>();
        }

        public List<Creature> At(int x, int y)
        {
            return At(new Point(x, y));
        }


    }
}
