namespace Simulator.Maps
{
    public abstract class SmallMap : Map
    {
        protected SmallMap(int sizeX, int sizeY) : base(sizeX, sizeY)
        {
            if (sizeX > 20 || sizeY > 20)
            {
                throw new ArgumentOutOfRangeException("Maksymalna wielkość mapy to 20");
            }
        }
    }
}
