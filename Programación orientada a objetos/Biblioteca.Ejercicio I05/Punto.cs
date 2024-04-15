namespace Geometria
{
    public class Punto
    {
        private readonly int x;
        private readonly int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX() 
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }
    }
}
